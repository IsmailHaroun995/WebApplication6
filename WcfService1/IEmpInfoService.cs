using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmpInfoService" in both code and config file together.
    [ServiceContract]
    public interface IEmpInfoService
    {
        [OperationContract]
        [WebInvoke(Method="GET",UriTemplate = "/EmpsalaryDetails/{EmpId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat =WebMessageFormat.Json,
            BodyStyle =WebMessageBodyStyle.Wrapped)]
        string GetEmpSalary(string EmpId);
    }
}
