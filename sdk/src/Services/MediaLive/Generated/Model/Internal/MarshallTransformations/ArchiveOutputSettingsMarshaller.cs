/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ArchiveOutputSettings Marshaller
    /// </summary>       
    public class ArchiveOutputSettingsMarshaller : IRequestMarshaller<ArchiveOutputSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ArchiveOutputSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetContainerSettings())
            {
                context.Writer.WritePropertyName("containerSettings");
                context.Writer.WriteObjectStart();

                var marshaller = ArchiveContainerSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainerSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExtension())
            {
                context.Writer.WritePropertyName("extension");
                context.Writer.Write(requestObject.Extension);
            }

            if(requestObject.IsSetNameModifier())
            {
                context.Writer.WritePropertyName("nameModifier");
                context.Writer.Write(requestObject.NameModifier);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ArchiveOutputSettingsMarshaller Instance = new ArchiveOutputSettingsMarshaller();

    }
}