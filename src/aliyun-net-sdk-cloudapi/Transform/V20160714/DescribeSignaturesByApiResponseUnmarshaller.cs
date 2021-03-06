/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeSignaturesByApiResponseUnmarshaller
    {
        public static DescribeSignaturesByApiResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeSignaturesByApiResponse describeSignaturesByApiResponse = new DescribeSignaturesByApiResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeSignaturesByApi.RequestId")
            };
            List<DescribeSignaturesByApiResponse.SignatureItem> signatures = new List<DescribeSignaturesByApiResponse.SignatureItem>();
			for (int i = 0; i < context.Length("DescribeSignaturesByApi.Signatures.Length"); i++) {
                DescribeSignaturesByApiResponse.SignatureItem signatureItem = new DescribeSignaturesByApiResponse.SignatureItem()
                {
                    SignatureId = context.StringValue($"DescribeSignaturesByApi.Signatures[{i}].SignatureId"),
                    SignatureName = context.StringValue($"DescribeSignaturesByApi.Signatures[{i}].SignatureName"),
                    BoundTime = context.StringValue($"DescribeSignaturesByApi.Signatures[{i}].BoundTime")
                };
                signatures.Add(signatureItem);
			}
			describeSignaturesByApiResponse.Signatures = signatures;
        
			return describeSignaturesByApiResponse;
        }
    }
}