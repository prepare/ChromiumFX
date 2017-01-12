// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using System;
using System.Net;

namespace CfxTestApplication {

    /// <summary>
    /// A user wrote me about problems using HttpWebResponse along with ChromiumFX
    /// so this is a test for his specific use case.
    /// Turns out there is no compatibility problem so far.
    /// </summary>
    class HttpWebResponseCompatTest {
        public static void Test() {
            var request = HttpWebRequest.Create("http://www.google.com");
            using(var response = request.GetResponse()) {
                using(var responseStream = response.GetResponseStream()) {
                    var reader = new System.IO.StreamReader(responseStream);
                    var html = reader.ReadToEnd();
                    System.Windows.Forms.MessageBox.Show(string.Format("Read {0} characters from System.Net.HttpWebResponse.", html.Length));
                }
            }
        }
    }
}
