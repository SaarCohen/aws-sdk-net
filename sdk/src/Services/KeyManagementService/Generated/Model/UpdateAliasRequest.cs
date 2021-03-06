/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAlias operation.
    /// Updates an alias to associate it with a different key.
    /// 
    ///  
    /// <para>
    /// An alias name can contain only alphanumeric characters, forward slashes (/), underscores
    /// (_), and dashes (-). An alias must start with the word "alias" followed by a forward
    /// slash (alias/). An alias that begins with "aws" after the forward slash (alias/aws...)
    /// is reserved by Amazon Web Services (AWS). 
    /// </para>
    ///  
    /// <para>
    /// An alias is not a property of a key. Therefore, an alias can be associated with and
    /// disassociated from an existing key without changing the properties of the key. 
    /// </para>
    ///  
    /// <para>
    /// Note that you cannot create or update an alias that represents a key in another account.
    /// </para>
    /// </summary>
    public partial class UpdateAliasRequest : AmazonKeyManagementServiceRequest
    {
        private string _aliasName;
        private string _targetKeyId;

        /// <summary>
        /// Gets and sets the property AliasName. String that contains the name of the alias to
        /// be modifed. The name must start with the word "alias" followed by a forward slash
        /// (alias/). Aliases that begin with "alias/AWS" are reserved.
        /// </summary>
        public string AliasName
        {
            get { return this._aliasName; }
            set { this._aliasName = value; }
        }

        // Check to see if AliasName property is set
        internal bool IsSetAliasName()
        {
            return this._aliasName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetKeyId. 
        /// <para>
        /// Unique identifier of the customer master key to be associated with the alias. This
        /// value can be a globally unique identifier or the fully specified ARN of a key. <ul>
        /// <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li>
        /// <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul>
        /// 
        /// </para>
        /// </summary>
        public string TargetKeyId
        {
            get { return this._targetKeyId; }
            set { this._targetKeyId = value; }
        }

        // Check to see if TargetKeyId property is set
        internal bool IsSetTargetKeyId()
        {
            return this._targetKeyId != null;
        }

    }
}