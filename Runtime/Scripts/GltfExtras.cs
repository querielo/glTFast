// Copyright 2020-2022 Andreas Atteneder
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.Collections.Generic;
using UnityEngine;

namespace GLTFast {

    [Serializable]
    public class ExtraData {
        public string key;
        public string value;
    }
    
    public class GltfExtras : MonoBehaviour {
        
        public ExtraData[] extras;

        public void SetData(Dictionary<string, string> data) {
            extras = new ExtraData[data.Count];
            var i = 0;
            foreach (var p in data) {
                extras[i] = new ExtraData();
                extras[i].key = p.Key;
                extras[i].value = p.Value;
                i++;
            }
        }
    }
}