// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

public class StructProperty {
    public readonly CefCallbackFunction Getter;
    public readonly CefCallbackFunction Setter;
    public readonly bool IsBoolean;

    public StructProperty(CefCallbackFunction getter, CefCallbackFunction setter, bool isBoolean) {
        this.Getter = getter;
        this.Setter = setter;
        this.IsBoolean = isBoolean;
        getter.IsProperty = true;
        getter.PublicPropertyName = PropertyName;
        if(setter != null) {
            setter.IsProperty = true;
            setter.PublicPropertyName = PropertyName;
        }
    }

    public string PropertyName {
        get {
            if(Getter.Name.StartsWith("get_")) {
                return Getter.PublicName.Substring(3);
            } else {
                return Getter.PublicName;
            }
        }
    }
}