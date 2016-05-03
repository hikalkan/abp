using Abp.Web;
using System.Reflection;
using System.Web.Http.Filters;

namespace Abp.WebApi.Controllers.Dynamic
{
    /// <summary>
    /// Used to store an action information of a dynamic ApiController.
    /// </summary>
    internal class DynamicApiActionInfo
    {
        /// <summary>
        /// Name of the action in the controller.
        /// </summary>
        public string ActionName { get; private set; }

        /// <summary>
        /// The method which will be invoked when this action is called.
        /// </summary>
        public MethodInfo Method { get; private set; }

        /// <summary>
        /// The HTTP verb that is used to call this action.
        /// </summary>
        public HttpVerb Verb { get; private set; }

        /// <summary>
        /// Dynamic Action Filters for this Controller Action.
        /// </summary>
        public IFilter[] Filters { get; set; }

        /// <summary>
        /// Createa a new <see cref="DynamicApiActionInfo"/> object.
        /// </summary>
        /// <param name="actionName">Name of the action in the controller</param>
        /// <param name="verb">The HTTP verb that is used to call this action</param>
        /// <param name="method">The method which will be invoked when this action is called</param>
        public DynamicApiActionInfo(string actionName, HttpVerb verb, MethodInfo method, IFilter[] filters = null)
        {
            ActionName = actionName;
            Verb = verb;
            Method = method;
            Filters = filters ?? new IFilter[] { }; //Assigning or initialzing the action filters.
        }
    }
}