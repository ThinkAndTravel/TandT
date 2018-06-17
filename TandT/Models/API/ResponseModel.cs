using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API
{
    public class ResponseModel<T> where T : class
    {
        /// <summary>
        /// Is request Success
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// Thing to return
        /// </summary>
        public T Message { get; set; }

        public ResponseModel(bool st, T mess) 
        {
            Status = st;
            Message = mess;
        }
    }
}
