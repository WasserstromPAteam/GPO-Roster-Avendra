using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using GPORosterAvendra_Dispatcher;

[assembly: WorkflowRunnerServiceAttribute(typeof(GPORosterAvendra_Dispatcher.WorkflowRunnerService))]
namespace GPORosterAvendra_Dispatcher
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Tests/MainTestCase.xaml
        /// </summary>
        public void MainTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\MainTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/MainTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void MainTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\MainTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/GetTransactionDataTestCase.xaml
        /// </summary>
        public void GetTransactionDataTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/GetTransactionDataTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void GetTransactionDataTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_TransactionField1", in_TransactionField1}, {"in_TransactionField2", in_TransactionField2}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_TransactionField1", in_TransactionField1}, {"in_TransactionField2", in_TransactionField2}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main(string in_OrchestratorQueueName, string in_OrchestratorQueueFolder, bool in_EmailTrigger)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_OrchestratorQueueName", in_OrchestratorQueueName}, {"in_OrchestratorQueueFolder", in_OrchestratorQueueFolder}, {"in_EmailTrigger", in_EmailTrigger}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(string in_OrchestratorQueueName, string in_OrchestratorQueueFolder, bool in_EmailTrigger, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_OrchestratorQueueName", in_OrchestratorQueueName}, {"in_OrchestratorQueueFolder", in_OrchestratorQueueFolder}, {"in_EmailTrigger", in_EmailTrigger}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
        public void WorkflowTestCaseTemplate()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void WorkflowTestCaseTemplate(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
        public void InitAllApplicationsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllApplicationsTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Google Address API Workflows/Portal Login.xaml
        /// </summary>
        public void Portal_Login(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Google Address API Workflows\Portal Login.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Google Address API Workflows/Portal Login.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Portal_Login(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Google Address API Workflows\Portal Login.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
        public string Process(System.Collections.Generic.Dictionary<string, object> in_Config, string in_AvendraFilePath, string in_GoogleAPIFileName, int in_AvendraInputRowsCount)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_AvendraFilePath", in_AvendraFilePath}, {"in_GoogleAPIFileName", in_GoogleAPIFileName}, {"in_AvendraInputRowsCount", in_AvendraInputRowsCount}}, default, default, default, GetAssemblyName());
            return (string)result["Out_PostponedTime"];
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string Process(System.Collections.Generic.Dictionary<string, object> in_Config, string in_AvendraFilePath, string in_GoogleAPIFileName, int in_AvendraInputRowsCount, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_AvendraFilePath", in_AvendraFilePath}, {"in_GoogleAPIFileName", in_GoogleAPIFileName}, {"in_AvendraInputRowsCount", in_AvendraInputRowsCount}}, default, isolated, default, GetAssemblyName());
            return (string)result["Out_PostponedTime"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        public (string out_AvendraFilePath, string out_GoogleAPIFileName, int out_AvendraInputRowsCount) InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
            return ((string)result["out_AvendraFilePath"], (string)result["out_GoogleAPIFileName"], (int)result["out_AvendraInputRowsCount"]);
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (string out_AvendraFilePath, string out_GoogleAPIFileName, int out_AvendraInputRowsCount) InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
            return ((string)result["out_AvendraFilePath"], (string)result["out_GoogleAPIFileName"], (int)result["out_AvendraInputRowsCount"]);
        }

        /// <summary>
        /// Invokes the Avendra/Create InputFile.xaml
        /// </summary>
        public (string out_AvendraInputPath, string Out_AvendraFilePathExcel, int Out_AvendraInputRowsCount) Create_InputFile(string BreakTriggerScopeInArgument, string in_DestinationPath, string in_AvendraFilePath, string in_GoogleRunsMasterFilePath, string in_CountriesToFilter, System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Avendra\Create InputFile.xaml", new Dictionary<string, object>{{"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}, {"in_DestinationPath", in_DestinationPath}, {"in_AvendraFilePath", in_AvendraFilePath}, {"in_GoogleRunsMasterFilePath", in_GoogleRunsMasterFilePath}, {"in_CountriesToFilter", in_CountriesToFilter}, {"in_Config", in_Config}}, default, default, default, GetAssemblyName());
            return ((string)result["out_AvendraInputPath"], (string)result["Out_AvendraFilePathExcel"], (int)result["Out_AvendraInputRowsCount"]);
        }

        /// <summary>
        /// Invokes the Avendra/Create InputFile.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (string out_AvendraInputPath, string Out_AvendraFilePathExcel, int Out_AvendraInputRowsCount) Create_InputFile(string BreakTriggerScopeInArgument, string in_DestinationPath, string in_AvendraFilePath, string in_GoogleRunsMasterFilePath, string in_CountriesToFilter, System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Avendra\Create InputFile.xaml", new Dictionary<string, object>{{"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}, {"in_DestinationPath", in_DestinationPath}, {"in_AvendraFilePath", in_AvendraFilePath}, {"in_GoogleRunsMasterFilePath", in_GoogleRunsMasterFilePath}, {"in_CountriesToFilter", in_CountriesToFilter}, {"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
            return ((string)result["out_AvendraInputPath"], (string)result["Out_AvendraFilePathExcel"], (int)result["Out_AvendraInputRowsCount"]);
        }

        /// <summary>
        /// Invokes the Tests/InitAllSettingsTestCase.xaml
        /// </summary>
        public void InitAllSettingsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllSettingsTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllSettingsTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Google Address API Workflows/Status_Check.xaml
        /// </summary>
        public void Status_Check(string In_FileName, string in_DestinationPath, System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Google Address API Workflows\Status_Check.xaml", new Dictionary<string, object>{{"In_FileName", In_FileName}, {"in_DestinationPath", in_DestinationPath}, {"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Google Address API Workflows/Status_Check.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Status_Check(string In_FileName, string in_DestinationPath, System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Google Address API Workflows\Status_Check.xaml", new Dictionary<string, object>{{"In_FileName", In_FileName}, {"in_DestinationPath", in_DestinationPath}, {"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Google Address API Workflows/PortalLogout.xaml
        /// </summary>
        public void PortalLogout()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Google Address API Workflows\PortalLogout.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Google Address API Workflows/PortalLogout.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void PortalLogout(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Google Address API Workflows\PortalLogout.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Google Address API Workflows/Navigate to upload page.xaml
        /// </summary>
        public void Navigate_to_upload_page()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Google Address API Workflows\Navigate to upload page.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Google Address API Workflows/Navigate to upload page.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Navigate_to_upload_page(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Google Address API Workflows\Navigate to upload page.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
        public string TakeScreenshot(string in_Folder, string io_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, default, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string TakeScreenshot(string in_Folder, string io_FilePath, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, isolated, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
        public void KillAllProcesses()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void KillAllProcesses(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, System.Data.DataTable io_dt_TransactionData) GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_TransactionData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_Config", in_Config}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, default, default, GetAssemblyName());
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, System.Data.DataTable io_dt_TransactionData) GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_TransactionData, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_Config", in_Config}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, isolated, default, GetAssemblyName());
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        public void CloseAllApplications(System.Collections.Generic.Dictionary<string, object> in_config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{{"in_config", in_config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CloseAllApplications(System.Collections.Generic.Dictionary<string, object> in_config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{{"in_config", in_config}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Edge Workflows/Navigate and download customer list.xaml
        /// </summary>
        public string Navigate_and_download_customer_list(string in_DestinationPath, System.Collections.Generic.Dictionary<string, object> in_config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Edge Workflows\Navigate and download customer list.xaml", new Dictionary<string, object>{{"in_DestinationPath", in_DestinationPath}, {"in_config", in_config}}, default, default, default, GetAssemblyName());
            return (string)result["Out_AvendraCustomerFilePath"];
        }

        /// <summary>
        /// Invokes the Edge Workflows/Navigate and download customer list.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string Navigate_and_download_customer_list(string in_DestinationPath, System.Collections.Generic.Dictionary<string, object> in_config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Edge Workflows\Navigate and download customer list.xaml", new Dictionary<string, object>{{"in_DestinationPath", in_DestinationPath}, {"in_config", in_config}}, default, isolated, default, GetAssemblyName());
            return (string)result["Out_AvendraCustomerFilePath"];
        }

        /// <summary>
        /// Invokes the Edge Workflows/Avendra Logout.xaml
        /// </summary>
        public void Avendra_Logout(System.Collections.Generic.Dictionary<string, object> in_config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Edge Workflows\Avendra Logout.xaml", new Dictionary<string, object>{{"in_config", in_config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Edge Workflows/Avendra Logout.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Avendra_Logout(System.Collections.Generic.Dictionary<string, object> in_config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Edge Workflows\Avendra Logout.xaml", new Dictionary<string, object>{{"in_config", in_config}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Read_Email.xaml
        /// </summary>
        public void Read_Email(System.Collections.Generic.Dictionary<string, object> in_Config, string BreakTriggerScopeInArgument)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Read_Email.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Read_Email.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Read_Email(System.Collections.Generic.Dictionary<string, object> in_Config, string BreakTriggerScopeInArgument, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Read_Email.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/ProcessTestCase.xaml
        /// </summary>
        public void ProcessTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\ProcessTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/ProcessTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ProcessTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\ProcessTestCase.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Google Address API Workflows/Upload the file.xaml
        /// </summary>
        public void Upload_the_file(string in_Upload_File_Path, System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Google Address API Workflows\Upload the file.xaml", new Dictionary<string, object>{{"in_Upload_File_Path", in_Upload_File_Path}, {"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Google Address API Workflows/Upload the file.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Upload_the_file(string in_Upload_File_Path, System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Google Address API Workflows\Upload the file.xaml", new Dictionary<string, object>{{"in_Upload_File_Path", in_Upload_File_Path}, {"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Google Address API Workflows/Download_Processed Output.xaml
        /// </summary>
        public void Download_Processed_Output(int in_rowIndex, string in_Status, string in_DestinationPath, System.Collections.Generic.Dictionary<string, object> in_Config, string In_FileName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Google Address API Workflows\Download_Processed Output.xaml", new Dictionary<string, object>{{"in_rowIndex", in_rowIndex}, {"in_Status", in_Status}, {"in_DestinationPath", in_DestinationPath}, {"in_Config", in_Config}, {"In_FileName", In_FileName}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Google Address API Workflows/Download_Processed Output.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Download_Processed_Output(int in_rowIndex, string in_Status, string in_DestinationPath, System.Collections.Generic.Dictionary<string, object> in_Config, string In_FileName, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Google Address API Workflows\Download_Processed Output.xaml", new Dictionary<string, object>{{"in_rowIndex", in_rowIndex}, {"in_Status", in_Status}, {"in_DestinationPath", in_DestinationPath}, {"in_Config", in_Config}, {"In_FileName", In_FileName}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Excel workflow/Remove unwanted column.xaml
        /// </summary>
        public void Remove_unwanted_column(string in_AvendraCustomerFile, System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Excel workflow\Remove unwanted column.xaml", new Dictionary<string, object>{{"in_AvendraCustomerFile", in_AvendraCustomerFile}, {"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Excel workflow/Remove unwanted column.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Remove_unwanted_column(string in_AvendraCustomerFile, System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Excel workflow\Remove unwanted column.xaml", new Dictionary<string, object>{{"in_AvendraCustomerFile", in_AvendraCustomerFile}, {"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Edge Workflows/Avendra login.xaml
        /// </summary>
        public void Avendra_login(System.Collections.Generic.Dictionary<string, object> in_config, string BreakTriggerScopeInArgument)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Edge Workflows\Avendra login.xaml", new Dictionary<string, object>{{"in_config", in_config}, {"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Edge Workflows/Avendra login.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Avendra_login(System.Collections.Generic.Dictionary<string, object> in_config, string BreakTriggerScopeInArgument, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Edge Workflows\Avendra login.xaml", new Dictionary<string, object>{{"in_config", in_config}, {"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Avendra/WriteAvendra_AccountsToGPOMasterFile.xaml
        /// </summary>
        public void WriteAvendra_AccountsToGPOMasterFile(string in_MasterGoogleRunsFile, System.Data.DataTable in_DT_AvendraCustomer)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Avendra\WriteAvendra_AccountsToGPOMasterFile.xaml", new Dictionary<string, object>{{"in_MasterGoogleRunsFile", in_MasterGoogleRunsFile}, {"in_DT_AvendraCustomer", in_DT_AvendraCustomer}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Avendra/WriteAvendra_AccountsToGPOMasterFile.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void WriteAvendra_AccountsToGPOMasterFile(string in_MasterGoogleRunsFile, System.Data.DataTable in_DT_AvendraCustomer, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Avendra\WriteAvendra_AccountsToGPOMasterFile.xaml", new Dictionary<string, object>{{"in_MasterGoogleRunsFile", in_MasterGoogleRunsFile}, {"in_DT_AvendraCustomer", in_DT_AvendraCustomer}}, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}