using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VPLBroker;
using BizBase;

namespace VPLBrokerTestHarness
{
    public partial class TestForm : Form
    {
        private object viewObject;
        private VoterRegistrationApplication selectedApp;

        public TestForm()
        {
            InitializeComponent();
            tsStatusLabel.Text = " *** Before using this tool you must establish an ElectionHub account for the platform selected.  Under 'Your API Settings' in ElectionHub copy 'API Key' and 'Private Key' into fields above and make sure your current IP Address is added.  (Production is Read-only) ***";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.tabActions.TabPages.Remove(this.tabQRCodeTestPage);  // Future
            txtAPIKey.Focus();
        }

        private bool loadControllingDomains()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ControllingDomains cds = new ControllingDomains(uri(), new Guid(txtAPIKey.Text), txtPrivateKey.Text, 300000);

                cds.load();

                foreach (ControllingDomain domain in cds.domains.Items)
                {
                    cboControllingDomain.Items.Add(domain);
                }
                return true;
            }
            catch (Exception ex)
            {
                showError("Cannot load Controlling Domains: " + ex.Message);
                return false;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }


        private void showError(string msg)
        {
            tsStatusLabel.IsLink = false;
            tsStatusLabel.ForeColor = System.Drawing.Color.IndianRed;
            tsStatusLabel.Text = msg;
        }

        private bool loadHoldReasons(int controllingDomainId, ComboBox cboHold)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Holdreasons reasons = new Holdreasons(uri(), new Guid(txtAPIKey.Text), txtPrivateKey.Text, 300000);
                reasons.load(controllingDomainId);

                foreach (Holdreason reason in reasons.Items)
                {
                    cboHold.Items.Add(reason);
                }
                return true;
            }
            catch (Exception ex)
            {
                showError("Cannot load Hold Reasons: " + ex.Message);
                return false;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }



        private bool loadRejectReasons(int controllingDomainId)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Rejectreasons reasons = new Rejectreasons(uri(), new Guid(txtAPIKey.Text), txtPrivateKey.Text, 300000);
                reasons.load(controllingDomainId);

                foreach (Rejectreason reason in reasons.Items)
                {
                    cboRejectReason.Items.Add(reason);
                }
                return true;
            }
            catch (Exception ex)
            {
                showError("Cannot load Reject Reasons: " + ex.Message);
                return false;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void setEnableStates()
        {

            btnAccept.Enabled = btnReceive.Enabled = btnReject.Enabled = cboRejectReason.Enabled = btnHold.Enabled = cboHoldReason.Enabled = txtAltID.Enabled = chkBlockResubmission.Enabled = false;
            btnHold.Text = "Put On Hold";

            if (selectedApp != null)
            {

                if (selectedApp.voterRegistrationApplicationStatusId == (int)voterRegistrationApplicationStatus.VPL_App_Status.RECEIVED)
                {
                    txtAltID.Enabled = cboRejectReason.Enabled = cboHoldReason.Enabled = true;
                }
                else if (selectedApp.voterRegistrationApplicationStatusId == (int)voterRegistrationApplicationStatus.VPL_App_Status.COMPLETE)
                {
                    btnReceive.Enabled = true;
                    txtReceiveVoterRegAppID.Text = selectedApp.voterRegistrationApplicationId.ToString();
                }
                else if (selectedApp.voterRegistrationApplicationStatusId == (int)voterRegistrationApplicationStatus.VPL_App_Status.REJECTED)
                {
                    txtAltID.Enabled = cboHoldReason.Enabled = true;
                }

                if (selectedApp.holdReasonId > 0)
                {
                    cboHoldReason.Enabled = false;
                    btnHold.Enabled = true;
                    btnHold.Text = "Take Off Hold";
                }
            }

        }

        private void btnContactBroker_Click(object sender, EventArgs e)
        {
            selectedApp = null;
            viewObject = null;
            tsStatusLabel.Text = "";
            TreeView tv = (TreeView)tvResults.Controls[0].Controls[0].Controls[0].Controls[0].Controls[0];

            tv.AfterSelect += tv_AfterSelect;

            tvResults.Clear();

            pnlMakeDecision.Enabled = false;


            if (cboControllingDomain.SelectedIndex < 0)
            {
                showError("Please select a Controlling Domain.");
                cboControllingDomain.Focus();
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                tsStatusLabel.Text = "";

                int controllingDomainId = ((ControllingDomain)cboControllingDomain.Items[cboControllingDomain.SelectedIndex]).domainId;
                string action = tabActions.SelectedTab.Text.ToLower();


                switch (action)
                {
                    case "basic broker call tests":
                        if (rdoGetQueue.Checked)
                        {
                            string qType = "Unspecified";

                            List<VoterRegistrationApplication> ret = new List<VoterRegistrationApplication>();
                            VoterRegistrationApplicationQueue appQ = new VoterRegistrationApplicationQueue(uri(), new Guid(txtAPIKey.Text), txtPrivateKey.Text, 300000);
                            appQ.controlling_domain_id = controllingDomainId;
                            appQ.hold_reason_id = cboFindHoldReason.SelectedIndex > -1 ? ((Holdreason)cboFindHoldReason.Items[cboFindHoldReason.SelectedIndex]).holdReasonId : 0;

                            if (rdoReceived.Checked)
                            {
                                ret = appQ.getReceivedPage((int)numPageNumber.Value, (int)numRecordsPerPage.Value);
                                qType = "Received";

                            }
                            else if (rdoCompleted.Checked)
                            {
                                ret = appQ.getCompletedPage((int)numPageNumber.Value, (int)numRecordsPerPage.Value);
                                qType = "Completed";
                            }
                            else if (rdoAccepted.Checked)
                            {
                                ret = appQ.getAcceptedPage((int)numPageNumber.Value, (int)numRecordsPerPage.Value);
                                qType = "Accepted";
                            }
                            else if (rdoRejected.Checked)
                            {
                                ret = appQ.getRejectedPage((int)numPageNumber.Value, (int)numRecordsPerPage.Value);
                                qType = "Rejected";
                            }


                            if (ret == null)
                            {
                                ret = new List<VoterRegistrationApplication>();
                            }

                            viewObject = ret;
                            tsStatusLabel.IsLink = true;
                            tsStatusLabel.Text = appQ.webAddress().Replace("&", "&&");

                            tvResults.Tag = ret.Count.ToString() + " " + qType + " Voter Registration Applications for " + cboControllingDomain.Text + (cboFindHoldReason.SelectedIndex == -1 ? " (Not on Hold)" : " (Hold Reason: " + cboFindHoldReason.Text + ")");
                            tvResults.Json = Slink.CommandFormat.ToJsonCustom<List<VoterRegistrationApplication>>(ret);

                        }
                        else if (rdoGetReg.Checked)
                        {
                            int regID = 0;
                            if (int.TryParse(txtRegID.Text, out regID))
                            {
                                VoterRegistrationApplication app = new VoterRegistrationApplication(uri(), new Guid(txtAPIKey.Text), txtPrivateKey.Text, 300000);
                                app.voterRegistrationApplicationId = regID;
                                app.load(controllingDomainId);

                                viewObject = app;

                                tvResults.Tag = "Voter Registration Application: (ID=" + app.voterRegistrationApplicationId + ")";
                                tvResults.Json = Slink.CommandFormat.ToJsonCustom<VoterRegistrationApplication>(app);
                                tsStatusLabel.IsLink = true;
                                tsStatusLabel.Text = app.webAddress().Replace("&", "&&");

                            }
                            else
                            {
                                showError("Must specify a proper Voter Registration Application ID");
                                txtRegID.Focus();
                            }


                        }
                        else if (rdoGetStats.Checked)
                        {
                            appstatistics stats = new appstatistics(uri(), new Guid(txtAPIKey.Text), txtPrivateKey.Text, 300000);
                            stats.load(null, controllingDomainId.ToString());
                            tvResults.Tag = "Voter Registration Application Statistics for " + cboControllingDomain.Text;
                            tvResults.Json = Slink.CommandFormat.ToJsonCustom<appstatistics>(stats);
                            viewObject = stats;
                            tsStatusLabel.IsLink = true;
                            tsStatusLabel.Text = stats.webAddress().Replace("&", "&&");
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                showError("Cannot Perfom Operation: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0 && viewObject is VoterRegistrationApplication)
            {
                selectedApp = (VoterRegistrationApplication)viewObject;
            }
            else
                if (e.Node.Level == 1 && viewObject is List<VoterRegistrationApplication>)
                {
                    int index = int.Parse(e.Node.Text.Substring(1, e.Node.Text.Length - 2));
                    selectedApp = ((List<VoterRegistrationApplication>)viewObject)[index];

                }



            if (selectedApp != null)
            {
                setEnableStates();
                txtRegID.Text = selectedApp.voterRegistrationApplicationId.ToString();
                txtReceiveVoterRegAppID.Text = txtRegID.Text;

                cboHoldReason.SelectedIndex = -1;
                cboRejectReason.SelectedIndex = -1;
                pnlMakeDecision.Enabled = !rdoProduction.Checked;

                string status = "Application ID=" + selectedApp.voterRegistrationApplicationId.ToString();
                if (selectedApp.voterRegistrationApplicationStatusId == (int)voterRegistrationApplicationStatus.VPL_App_Status.RECEIVED)
                {
                    status += " , Application Status is Received ";
                }
                else if (selectedApp.voterRegistrationApplicationStatusId == (int)voterRegistrationApplicationStatus.VPL_App_Status.COMPLETE)
                {
                    status += " , Application Status is Complete ";
                }
                else if (selectedApp.voterRegistrationApplicationStatusId == (int)voterRegistrationApplicationStatus.VPL_App_Status.ACCEPTED)
                {
                    status += " , Application Status is Accepted - no further status changes are possible at this time. ";
                }
                else if (selectedApp.voterRegistrationApplicationStatusId == (int)voterRegistrationApplicationStatus.VPL_App_Status.REJECTED)
                {
                    status += " , Application Status is Rejected ";
                    if (selectedApp.rejectReasonId > 0)
                    {
                        status += "(RejectReasonID=" + selectedApp.rejectReasonId.ToString() + ")";

                        if (selectedApp.blockResubmission)
                        {
                            status += " - resubmission is blocked.";
                        }
                    }
                }

                if (selectedApp.holdReasonId > 0)
                {
                    status += " [Application is on HOLD] ";
                }
                tsStatusLabel.IsLink = false;
                tsStatusLabel.ForeColor = System.Drawing.Color.DarkGreen;
                tsStatusLabel.Text = status;
            }

        }

        private string uri()
        {
            string uri = "http://localhost/voterplace/admin/";

            if (rdoTest.Checked)
                uri = "http://vpltest.com/admin/";
            else if (rdoProduction.Checked)
                uri = "http://voterplace.com/admin/";

            return uri;
        }
        private void rdoGetQueue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGetQueue.Checked)
            {
                pnlRegKey.Enabled = false;
                pnlQueueTypes.Enabled = true;
                numPageNumber.Enabled = true;
                numRecordsPerPage.Enabled = true;
                btnContactBroker.Enabled = rdoAccepted.Checked || rdoCompleted.Checked || rdoReceived.Checked || rdoRejected.Checked;
            }
            else
            {
                pnlQueueTypes.Enabled = false;
                numPageNumber.Enabled = false;
                numRecordsPerPage.Enabled = false;
            }
        }

        private void rdoGetReg_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGetReg.Checked)
            {
                pnlRegKey.Enabled = true;
                pnlQueueTypes.Enabled = false;
                txtRegID.Focus();
                btnContactBroker.Enabled = true;
            }
            else
                pnlRegKey.Enabled = false;
        }

        void tvResults_Click(object sender, System.EventArgs e)
        {

        }

        private string platform()
        {
            string platform = "localhost";
            if (rdoTest.Checked)
                platform = "test environment";
            if (rdoProduction.Checked)
                platform = "production environment";

            return platform;
        }

        void cboControllingDomain_DropDown(object sender, System.EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAPIKey.Text))
            {
                showError("You must enter a valid API Key for " + platform());
                txtAPIKey.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrivateKey.Text))
            {
                showError("You must enter a valid Private Key for " + platform());
                txtPrivateKey.Focus();
                return;
            }
            if (!platform().Equals(cboControllingDomain.Tag))
            {
                cboControllingDomain.Items.Clear();
                if (loadControllingDomains())
                    cboControllingDomain.Tag = platform();
            }

        }

        private void updateStatus(int statusId, bool onHold = false)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                VoterRegistrationApplicationDecision decision = new VoterRegistrationApplicationDecision(uri(), new Guid(txtAPIKey.Text), txtPrivateKey.Text, 300000);

                if (onHold)
                {
                    if (cboHoldReason.SelectedIndex > -1)
                    {
                        decision.holdReasonId = ((Holdreason)cboHoldReason.Items[cboHoldReason.SelectedIndex]).holdReasonId;
                        decision.reason = cboHoldReason.Text;
                    }


                }
                else if (statusId == (int)voterRegistrationApplicationStatus.VPL_App_Status.REJECTED)
                {
                    if (cboRejectReason.SelectedIndex > -1)
                    {
                        decision.rejectReasonId = ((Rejectreason)cboRejectReason.Items[cboRejectReason.SelectedIndex]).rejectReasonId;
                        decision.reason = cboRejectReason.Text;
                    }

                    if (chkBlockResubmission.Checked)
                    {
                        decision.blockResubmission = true;
                    }
                }
                else if (statusId == (int)voterRegistrationApplicationStatus.VPL_App_Status.ACCEPTED)
                {
                    decision.voterAltId = txtAltID.Text;
                }


                decision.voterRegistrationApplicationId = this.selectedApp.voterRegistrationApplicationId;
                decision.voterRegistrationApplicationStatusId = statusId;

                decision.save();
            }
            catch (Exception ex)
            {
                showError("Unable to update status on Voter Registration Application: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }



        private void btnReceive_Click(object sender, EventArgs e)
        {
            updateStatus((int)voterRegistrationApplicationStatus.VPL_App_Status.RECEIVED);

        }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            updateStatus((int)voterRegistrationApplicationStatus.VPL_App_Status.ACCEPTED);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            updateStatus((int)voterRegistrationApplicationStatus.VPL_App_Status.REJECTED);
        }

        private void btnScanAffidavits_Click(object sender, EventArgs e)
        {

        }

        private void refreshResults()
        {

        }

        private void rdoGetStats_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGetStats.Checked)
                btnContactBroker.Enabled = true;

        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            if (this.selectedApp != null)
            {
                int currentStatusID = selectedApp.voterRegistrationApplicationStatusId;
                updateStatus(currentStatusID, true);
            }
        }

        void cboHoldReason_DropDown(object sender, System.EventArgs e)
        {
            int controllingDomainId = ((ControllingDomain)cboControllingDomain.Items[cboControllingDomain.SelectedIndex]).domainId;
            string platformAndControllingDomainId = platform() + "." + controllingDomainId.ToString();

            if (!platform().Equals(cboHoldReason.Tag))
            {
                cboHoldReason.Items.Clear();
                if (loadHoldReasons(controllingDomainId, cboHoldReason))
                    cboHoldReason.Tag = platform();

            }

        }

        void cboRejectReason_DropDown(object sender, System.EventArgs e)
        {
            int controllingDomainId = ((ControllingDomain)cboControllingDomain.Items[cboControllingDomain.SelectedIndex]).domainId;
            string platformAndControllingDomainId = platform() + "." + controllingDomainId.ToString();

            if (!platform().Equals(cboRejectReason.Tag))
            {
                cboRejectReason.Items.Clear();
                if (loadRejectReasons(controllingDomainId))
                    cboRejectReason.Tag = platform();

            }

        }

        private void rdoCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCompleted.Checked)
                cboFindHoldReason.Enabled = btnContactBroker.Enabled = true;
        }

        private void rdoReceived_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoReceived.Checked)
                cboFindHoldReason.Enabled = btnContactBroker.Enabled = true;

        }

        private void rdoAccepted_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAccepted.Checked)
                cboFindHoldReason.Enabled = btnContactBroker.Enabled = true;

        }

        private void rdoRejected_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRejected.Checked)
                cboFindHoldReason.Enabled = btnContactBroker.Enabled = true;

        }

        void cboRejectReason_TextChanged(object sender, System.EventArgs e)
        {
            btnReject.Enabled = chkBlockResubmission.Enabled = (!string.IsNullOrWhiteSpace(cboRejectReason.Text));
            if (!chkBlockResubmission.Enabled)
            {
                chkBlockResubmission.Checked = false;
            }
        }

        void cboHoldReason_TextChanged(object sender, System.EventArgs e)
        {
            btnHold.Enabled = (!string.IsNullOrWhiteSpace(cboHoldReason.Text));
        }


        void cboFindHoldReason_DropDown(object sender, System.EventArgs e)
        {
            int controllingDomainId = ((ControllingDomain)cboControllingDomain.Items[cboControllingDomain.SelectedIndex]).domainId;
            string platformAndControllingDomainId = platform() + "." + controllingDomainId.ToString();

            if (!platform().Equals(cboFindHoldReason.Tag))
            {
                cboFindHoldReason.Items.Clear();
                if (loadHoldReasons(controllingDomainId, cboFindHoldReason))
                    cboFindHoldReason.Tag = platform();

            }

        }


        private void cboControllingDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboControllingDomain.SelectedIndex > -1)
            {
                pnlReadTransactions.Enabled = true;
            }
        }

        private void cboRejectReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReject.Enabled = chkBlockResubmission.Enabled = (cboRejectReason.SelectedIndex > -1);
        }

        private void cboHoldReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnHold.Enabled = (cboHoldReason.SelectedIndex > -1);
        }

        private void txtAltID_TextChanged(object sender, EventArgs e)
        {
            btnAccept.Enabled = !string.IsNullOrWhiteSpace(txtAltID.Text);
        }

        private void txtAPIKey_TextChanged(object sender, EventArgs e)
        {
            cboControllingDomain.Enabled = (!string.IsNullOrWhiteSpace(txtAPIKey.Text) && !string.IsNullOrWhiteSpace(txtPrivateKey.Text));
        }

        private void txtPrivateKey_TextChanged(object sender, EventArgs e)
        {
            cboControllingDomain.Enabled = (!string.IsNullOrWhiteSpace(txtAPIKey.Text) && !string.IsNullOrWhiteSpace(txtPrivateKey.Text));
        }

        private void lnkHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Specify that the link was visited. 
            this.lnkHub.LinkVisited = true;

            string url = "https://electionhub.com";

            if (rdoLocalHost.Checked)
                url = "http://localhost/electionhub";
            else if (rdoTest.Checked)
                url = "http://ehubtest.com";

            // Navigate to a URL.
            System.Diagnostics.Process.Start(url);

        }


    }
}
