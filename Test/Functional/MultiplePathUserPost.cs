/*
 * Copyright 2016 MasterCard International.
 *
 * Redistribution and use in source and binary forms, with or without modification, are 
 * permitted provided that the following conditions are met:
 *
 * Redistributions of source code must retain the above copyright notice, this list of 
 * conditions and the following disclaimer.
 * Redistributions in binary form must reproduce the above copyright notice, this list of 
 * conditions and the following disclaimer in the documentation and/or other materials 
 * provided with the distribution.
 * Neither the name of the MasterCard International Incorporated nor the names of its 
 * contributors may be used to endorse or promote products derived from this software 
 * without specific prior written permission.
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY 
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES 
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT 
 * SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
 * INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED
 * TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; 
 * OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER 
 * IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING 
 * IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF 
 * SUCH DAMAGE.
 *
 */

using System;
using System.Collections.Generic;
using MasterCard.Core;
using MasterCard.Core.Exceptions;
using MasterCard.Core.Model;
using MasterCard.Core.Security;


namespace TestMasterCard
{
    public class MultiplePathUserPost : BaseObject
    {

        public MultiplePathUserPost(RequestMap bm) : base(bm)
        {
		}

        public MultiplePathUserPost() : base()
        {
        }

        private static readonly Dictionary<string, OperationConfig> _store = new Dictionary<string, OperationConfig>
        {
        {"769e324e-d45c-4164-9771-f25a1531fa36", new OperationConfig("/mock_crud_server/users/{user_id}/post/{post_id}", "list", new List<String> {  }, new List<String> {  })},
        {"fb8fb281-ba2e-45c1-9d20-91173aed6995", new OperationConfig("/mock_crud_server/users/{user_id}/post/{post_id}", "update", new List<String> { "testQuery" }, new List<String> {  })},
        {"84910aee-b8c5-4d86-b84c-0dc822e6937d", new OperationConfig("/mock_crud_server/users/{user_id}/post/{post_id}", "delete", new List<String> {  }, new List<String> {  })},
        
        };

        protected override OperationConfig GetOperationConfig(string operationUUID)
        {
            if (!_store.ContainsKey(operationUUID))
            {
                throw new System.ArgumentException("Invalid operationUUID supplied: " + operationUUID);
            }
            return _store[operationUUID];
        }

        protected override OperationMetadata GetOperationMetadata()
        {
            return new OperationMetadata(ResourceConfig.Instance.GetVersion(), ResourceConfig.Instance.GetHost(), ResourceConfig.Instance.GetContext());
        }

        
        
        
        
        
        /// <summary>
        /// Retrieves a list of type <code>MultiplePathUserPost</code>
        /// </summary>
        /// <returns> A list MultiplePathUserPost of objects </returns>
        /// <exception cref="ApiCommunicationException"> </exception>
        /// <exception cref="AuthenticationException"> </exception>
        /// <exception cref="InvalidRequestException"> </exception>
        /// <exception cref="NotAllowedException"> </exception>
        /// <exception cref="ObjectNotFoundException"> </exception>
        /// <exception cref="SystemException"> </exception>
        public static List<MultiplePathUserPost> List()
        {
            return BaseObject.ExecuteForList("769e324e-d45c-4164-9771-f25a1531fa36", new MultiplePathUserPost());
        }

        /// <summary>
        /// Retrieves a list of type <code>MultiplePathUserPost</code> using the specified criteria
        /// </summary>
        /// <param name="criteria">The criteria set of values which is used to identify the set of records of MultiplePathUserPost object to return</praram>
        /// <returns>  a List of MultiplePathUserPost objects which holds the list objects available. </returns>
        /// <exception cref="ApiCommunicationException"> </exception>
        /// <exception cref="AuthenticationException"> </exception>
        /// <exception cref="InvalidRequestException"> </exception>
        /// <exception cref="NotAllowedException"> </exception>
        /// <exception cref="ObjectNotFoundException"> </exception>
        /// <exception cref="SystemException"> </exception>
        public static List<MultiplePathUserPost> List(RequestMap criteria)
        {
            return BaseObject.ExecuteForList("769e324e-d45c-4164-9771-f25a1531fa36", new MultiplePathUserPost(criteria));
        }
        
        
        
        
        
        
        /// <summary>
        /// Updates an object of type <code>MultiplePathUserPost</code>
        /// </summary>
        /// <returns> A MultiplePathUserPost object </returns>
        /// <exception cref="ApiCommunicationException"> </exception>
        /// <exception cref="AuthenticationException"> </exception>
        /// <exception cref="InvalidRequestException"> </exception>
        /// <exception cref="NotAllowedException"> </exception>
        /// <exception cref="ObjectNotFoundException"> </exception>
        /// <exception cref="SystemException"> </exception>
        public MultiplePathUserPost Update()
        {
            return  BaseObject.Execute("fb8fb281-ba2e-45c1-9d20-91173aed6995",this);
        }

        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Delete this object of type <code>MultiplePathUserPost</code>
        /// </summary>
        /// <returns> A MultiplePathUserPost object </returns>
        /// <exception cref="ApiCommunicationException"> </exception>
        /// <exception cref="AuthenticationException"> </exception>
        /// <exception cref="InvalidRequestException"> </exception>
        /// <exception cref="NotAllowedException"> </exception>
        /// <exception cref="ObjectNotFoundException"> </exception>
        /// <exception cref="SystemException"> </exception>
        public MultiplePathUserPost Delete()
        {
            return BaseObject.Execute("84910aee-b8c5-4d86-b84c-0dc822e6937d", this);
        }

        /// <summary>
        /// Delete an object of type <code>MultiplePathUserPost</code>
        /// </summary>
        /// <param name="id">The unique identifier which is used to identify an MultiplePathUserPost object.</param>
        /// <returns> A MultiplePathUserPost object </returns>
        /// <exception cref="ApiCommunicationException"> </exception>
        /// <exception cref="AuthenticationException"> </exception>
        /// <exception cref="InvalidRequestException"> </exception>
        /// <exception cref="NotAllowedException"> </exception>
        /// <exception cref="ObjectNotFoundException"> </exception>
        /// <exception cref="SystemException"> </exception>
        public static MultiplePathUserPost Delete(String id)
        {
            return BaseObject.Execute("84910aee-b8c5-4d86-b84c-0dc822e6937d", new MultiplePathUserPost(new RequestMap("id", id)));
        }

        /// <summary>
        /// Delete an object of type <code>MultiplePathUserPost</code>
        /// </summary>
        /// <param name="id">The unique identifier which is used to identify an MultiplePathUserPost object.</param>
        /// <param name="parameters">additional parameters</param>
        /// <returns> A MultiplePathUserPost object </returns>
        /// <exception cref="ApiCommunicationException"> </exception>
        /// <exception cref="AuthenticationException"> </exception>
        /// <exception cref="InvalidRequestException"> </exception>
        /// <exception cref="NotAllowedException"> </exception>
        /// <exception cref="ObjectNotFoundException"> </exception>
        /// <exception cref="SystemException"> </exception>
        public static MultiplePathUserPost Delete(String id, RequestMap parameters)
        {
            RequestMap map = new RequestMap();
            map.Set("id", id);
            map.AddAll (parameters);
            return BaseObject.Execute("84910aee-b8c5-4d86-b84c-0dc822e6937d", new MultiplePathUserPost(map));
        }
        
        
        
        
    }
}


