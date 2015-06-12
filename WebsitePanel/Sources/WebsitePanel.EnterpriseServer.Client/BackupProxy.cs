// Copyright (c) 2015, Outercurve Foundation.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  Outercurve Foundation  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.3038.
// 
namespace WebsitePanel.EnterpriseServer {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
	using WebsitePanel.EnterpriseServer;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="esBackupSoap", Namespace="http://smbsaas/websitepanel/enterpriseserver")]
    public partial class esBackup : Microsoft.Web.Services3.WebServicesClientProtocol {
        
        private System.Threading.SendOrPostCallback GetBackupContentSummaryOperationCompleted;
        
        private System.Threading.SendOrPostCallback BackupOperationCompleted;
        
        private System.Threading.SendOrPostCallback RestoreOperationCompleted;
        
        /// <remarks/>
        public esBackup() {
            this.Url = "http://localhost:1625/esBackup.asmx";
        }
        
        /// <remarks/>
        public event GetBackupContentSummaryCompletedEventHandler GetBackupContentSummaryCompleted;
        
        /// <remarks/>
        public event BackupCompletedEventHandler BackupCompleted;
        
        /// <remarks/>
        public event RestoreCompletedEventHandler RestoreCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/GetBackupContentSummary", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public KeyValueBunch GetBackupContentSummary(int userId, int packageId, int serviceId, int serverId) {
            object[] results = this.Invoke("GetBackupContentSummary", new object[] {
                        userId,
                        packageId,
                        serviceId,
                        serverId});
            return ((KeyValueBunch)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetBackupContentSummary(int userId, int packageId, int serviceId, int serverId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetBackupContentSummary", new object[] {
                        userId,
                        packageId,
                        serviceId,
                        serverId}, callback, asyncState);
        }
        
        /// <remarks/>
        public KeyValueBunch EndGetBackupContentSummary(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((KeyValueBunch)(results[0]));
        }
        
        /// <remarks/>
        public void GetBackupContentSummaryAsync(int userId, int packageId, int serviceId, int serverId) {
            this.GetBackupContentSummaryAsync(userId, packageId, serviceId, serverId, null);
        }
        
        /// <remarks/>
        public void GetBackupContentSummaryAsync(int userId, int packageId, int serviceId, int serverId, object userState) {
            if ((this.GetBackupContentSummaryOperationCompleted == null)) {
                this.GetBackupContentSummaryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBackupContentSummaryOperationCompleted);
            }
            this.InvokeAsync("GetBackupContentSummary", new object[] {
                        userId,
                        packageId,
                        serviceId,
                        serverId}, this.GetBackupContentSummaryOperationCompleted, userState);
        }
        
        private void OnGetBackupContentSummaryOperationCompleted(object arg) {
            if ((this.GetBackupContentSummaryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetBackupContentSummaryCompleted(this, new GetBackupContentSummaryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/Backup", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Backup(bool async, string taskId, int userId, int packageId, int serviceId, int serverId, string backupFileName, int storePackageId, string storePackageFolder, string storeServerFolder, bool deleteTempBackup) {
            object[] results = this.Invoke("Backup", new object[] {
                        async,
                        taskId,
                        userId,
                        packageId,
                        serviceId,
                        serverId,
                        backupFileName,
                        storePackageId,
                        storePackageFolder,
                        storeServerFolder,
                        deleteTempBackup});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginBackup(bool async, string taskId, int userId, int packageId, int serviceId, int serverId, string backupFileName, int storePackageId, string storePackageFolder, string storeServerFolder, bool deleteTempBackup, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Backup", new object[] {
                        async,
                        taskId,
                        userId,
                        packageId,
                        serviceId,
                        serverId,
                        backupFileName,
                        storePackageId,
                        storePackageFolder,
                        storeServerFolder,
                        deleteTempBackup}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndBackup(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void BackupAsync(bool async, string taskId, int userId, int packageId, int serviceId, int serverId, string backupFileName, int storePackageId, string storePackageFolder, string storeServerFolder, bool deleteTempBackup) {
            this.BackupAsync(async, taskId, userId, packageId, serviceId, serverId, backupFileName, storePackageId, storePackageFolder, storeServerFolder, deleteTempBackup, null);
        }
        
        /// <remarks/>
        public void BackupAsync(bool async, string taskId, int userId, int packageId, int serviceId, int serverId, string backupFileName, int storePackageId, string storePackageFolder, string storeServerFolder, bool deleteTempBackup, object userState) {
            if ((this.BackupOperationCompleted == null)) {
                this.BackupOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBackupOperationCompleted);
            }
            this.InvokeAsync("Backup", new object[] {
                        async,
                        taskId,
                        userId,
                        packageId,
                        serviceId,
                        serverId,
                        backupFileName,
                        storePackageId,
                        storePackageFolder,
                        storeServerFolder,
                        deleteTempBackup}, this.BackupOperationCompleted, userState);
        }
        
        private void OnBackupOperationCompleted(object arg) {
            if ((this.BackupCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BackupCompleted(this, new BackupCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/Restore", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Restore(bool async, string taskId, int userId, int packageId, int serviceId, int serverId, int storePackageId, string storePackageBackupPath, string storeServerBackupPath) {
            object[] results = this.Invoke("Restore", new object[] {
                        async,
                        taskId,
                        userId,
                        packageId,
                        serviceId,
                        serverId,
                        storePackageId,
                        storePackageBackupPath,
                        storeServerBackupPath});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginRestore(bool async, string taskId, int userId, int packageId, int serviceId, int serverId, int storePackageId, string storePackageBackupPath, string storeServerBackupPath, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Restore", new object[] {
                        async,
                        taskId,
                        userId,
                        packageId,
                        serviceId,
                        serverId,
                        storePackageId,
                        storePackageBackupPath,
                        storeServerBackupPath}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndRestore(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void RestoreAsync(bool async, string taskId, int userId, int packageId, int serviceId, int serverId, int storePackageId, string storePackageBackupPath, string storeServerBackupPath) {
            this.RestoreAsync(async, taskId, userId, packageId, serviceId, serverId, storePackageId, storePackageBackupPath, storeServerBackupPath, null);
        }
        
        /// <remarks/>
        public void RestoreAsync(bool async, string taskId, int userId, int packageId, int serviceId, int serverId, int storePackageId, string storePackageBackupPath, string storeServerBackupPath, object userState) {
            if ((this.RestoreOperationCompleted == null)) {
                this.RestoreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRestoreOperationCompleted);
            }
            this.InvokeAsync("Restore", new object[] {
                        async,
                        taskId,
                        userId,
                        packageId,
                        serviceId,
                        serverId,
                        storePackageId,
                        storePackageBackupPath,
                        storeServerBackupPath}, this.RestoreOperationCompleted, userState);
        }
        
        private void OnRestoreOperationCompleted(object arg) {
            if ((this.RestoreCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RestoreCompleted(this, new RestoreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void GetBackupContentSummaryCompletedEventHandler(object sender, GetBackupContentSummaryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetBackupContentSummaryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetBackupContentSummaryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public KeyValueBunch Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((KeyValueBunch)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void BackupCompletedEventHandler(object sender, BackupCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BackupCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BackupCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void RestoreCompletedEventHandler(object sender, RestoreCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RestoreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RestoreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}
