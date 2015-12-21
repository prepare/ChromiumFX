// Copyright (c) 2014-2015 Wolfgang Borgsm�ller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System.Drawing;
using System.IO;

namespace Chromium.WebBrowser {
    internal static class Images {
        internal static class ArrowDown {
            internal static Image Create() {
                var data = new byte[] {
                    137, 080, 078, 071, 013, 010, 026, 010, 000, 000, 000, 013, 073, 072, 068, 082, 
                    000, 000, 000, 010, 000, 000, 000, 006, 008, 006, 000, 000, 000, 250, 240, 015, 
                    198, 000, 000, 000, 191, 073, 068, 065, 084, 008, 215, 101, 202, 193, 078, 194, 
                    080, 016, 064, 209, 059, 180, 208, 130, 191, 164, 009, 137, 074, 132, 096, 140, 
                    137, 225, 051, 137, 009, 054, 096, 009, 032, 011, 255, 196, 164, 213, 165, 125, 
                    125, 237, 076, 193, 231, 206, 141, 139, 179, 059, 120, 239, 195, 102, 123, 008, 
                    102, 246, 079, 229, 092, 120, 221, 189, 005, 051, 011, 241, 115, 150, 083, 148, 
                    095, 084, 174, 230, 126, 122, 131, 136, 000, 160, 102, 172, 054, 059, 202, 242, 
                    147, 218, 121, 122, 183, 227, 043, 070, 023, 035, 062, 138, 130, 229, 106, 205, 
                    249, 252, 131, 170, 145, 229, 007, 084, 059, 210, 052, 229, 122, 124, 137, 168, 
                    106, 248, 174, 028, 203, 151, 156, 174, 051, 004, 072, 135, 067, 146, 036, 065, 
                    091, 101, 241, 056, 163, 031, 199, 072, 219, 182, 065, 068, 112, 181, 039, 219, 
                    030, 025, 012, 250, 136, 244, 240, 222, 179, 120, 184, 035, 138, 034, 000, 164, 
                    105, 154, 000, 032, 034, 212, 190, 097, 189, 127, 231, 116, 050, 158, 230, 147, 
                    191, 004, 240, 011, 131, 032, 116, 042, 192, 252, 107, 013, 000, 000, 000, 000, 
                    073, 069, 078, 068, 174, 066, 096, 130, 
                };
                var stream = new MemoryStream(data);
                return Image.FromStream(stream);
            }
        }
        internal static class ArrowUp {
            internal static Image Create() {
                var data = new byte[] {
                    137, 080, 078, 071, 013, 010, 026, 010, 000, 000, 000, 013, 073, 072, 068, 082, 
                    000, 000, 000, 010, 000, 000, 000, 006, 008, 006, 000, 000, 000, 250, 240, 015, 
                    198, 000, 000, 000, 212, 073, 068, 065, 084, 008, 215, 061, 138, 049, 074, 003, 
                    081, 020, 000, 231, 175, 017, 179, 113, 085, 004, 075, 033, 224, 037, 210, 040, 
                    068, 193, 198, 019, 040, 196, 020, 081, 016, 111, 145, 147, 216, 216, 088, 088, 
                    008, 138, 024, 037, 068, 020, 241, 038, 145, 036, 133, 136, 251, 222, 255, 127, 
                    093, 125, 022, 154, 012, 076, 053, 227, 138, 162, 048, 254, 017, 245, 156, 157, 
                    095, 080, 150, 037, 167, 071, 109, 170, 213, 133, 105, 194, 197, 024, 013, 064, 
                    068, 185, 188, 190, 099, 190, 082, 065, 069, 016, 081, 078, 058, 173, 217, 236, 
                    098, 140, 150, 231, 194, 213, 109, 159, 044, 171, 241, 099, 070, 008, 225, 111, 
                    086, 229, 184, 125, 192, 098, 045, 197, 141, 198, 019, 187, 185, 127, 036, 077, 
                    083, 086, 150, 050, 118, 182, 026, 152, 025, 189, 193, 011, 195, 225, 027, 170, 
                    066, 231, 112, 159, 185, 230, 238, 094, 247, 171, 252, 102, 109, 117, 153, 237, 
                    205, 006, 206, 057, 146, 036, 097, 163, 190, 206, 251, 199, 039, 121, 046, 140, 
                    198, 019, 008, 033, 088, 255, 233, 213, 084, 213, 188, 247, 051, 067, 008, 166, 
                    170, 246, 048, 120, 054, 239, 189, 253, 002, 218, 098, 121, 049, 240, 136, 172, 
                    109, 000, 000, 000, 000, 073, 069, 078, 068, 174, 066, 096, 130, 
                };
                var stream = new MemoryStream(data);
                return Image.FromStream(stream);
            }
        }
        internal static class Cross {
            internal static Image Create() {
                var data = new byte[] {
                    137, 080, 078, 071, 013, 010, 026, 010, 000, 000, 000, 013, 073, 072, 068, 082, 
                    000, 000, 000, 010, 000, 000, 000, 010, 008, 006, 000, 000, 000, 141, 050, 207, 
                    189, 000, 000, 000, 163, 073, 068, 065, 084, 024, 211, 117, 206, 177, 013, 131, 
                    048, 020, 004, 208, 051, 158, 129, 009, 104, 088, 009, 240, 014, 172, 144, 029, 
                    040, 024, 008, 144, 063, 244, 236, 113, 013, 165, 117, 041, 018, 035, 130, 200, 
                    073, 191, 186, 247, 165, 067, 008, 065, 219, 182, 137, 228, 227, 153, 153, 154, 
                    166, 017, 166, 105, 082, 008, 065, 235, 186, 254, 069, 049, 070, 129, 164, 158, 
                    240, 021, 145, 252, 064, 146, 154, 231, 089, 121, 070, 070, 102, 118, 062, 058, 
                    146, 194, 055, 251, 190, 099, 028, 071, 164, 148, 208, 247, 061, 234, 186, 206, 
                    021, 010, 092, 226, 189, 071, 074, 009, 069, 081, 192, 057, 135, 159, 220, 055, 
                    153, 153, 150, 101, 081, 215, 117, 063, 155, 113, 071, 185, 136, 049, 170, 109, 
                    219, 019, 227, 009, 221, 177, 153, 201, 031, 199, 241, 186, 015, 207, 041, 203, 
                    018, 085, 085, 097, 024, 006, 188, 001, 180, 027, 253, 017, 242, 216, 173, 066, 
                    000, 000, 000, 000, 073, 069, 078, 068, 174, 066, 096, 130, 
                };
                var stream = new MemoryStream(data);
                return Image.FromStream(stream);
            }
        }
    }
}
