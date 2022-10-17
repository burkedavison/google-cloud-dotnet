// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Speech.V2.Snippets
{
    // [START speech_v2_generated_Speech_CreateRecognizer_async_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Speech.V2;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSpeechClientSnippets
    {
        /// <summary>Snippet for CreateRecognizerAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateRecognizerResourceNamesAsync()
        {
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Recognizer recognizer = new Recognizer();
            string recognizerId = "";
            // Make the request
            Operation<Recognizer, OperationMetadata> response = await speechClient.CreateRecognizerAsync(parent, recognizer, recognizerId);

            // Poll until the returned long-running operation is complete
            Operation<Recognizer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Recognizer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Recognizer, OperationMetadata> retrievedResponse = await speechClient.PollOnceCreateRecognizerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Recognizer retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END speech_v2_generated_Speech_CreateRecognizer_async_flattened_resourceNames]
}