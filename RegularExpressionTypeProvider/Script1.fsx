#r @".\bin\Debug\RegularExpressionTypeProvider.dll"


type T = Samples.ShareInfo.TPTest.RegularExpressionTypeProvider< @"(?<AreaCode>^\d{3})-(?<PhoneNumber>\d{3}-\d{4}$)" >

let reg = T()
let result = T.IsMatch("425-555-2345")
let r = reg.Match("425-555-2345").AreaCode.Value