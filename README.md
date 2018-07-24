# NrsLib.CSharpToTypescriptInterface

C# の dll から Typescript の interface を作成するライブラリです。  

解説: [https://nrslib.com/csharp-to-typescript-interface/](https://nrslib.com/csharp-to-typescript-interface/)  
nuget: [https://www.nuget.org/packages/NrsLib.CSharpToTypescriptInterface/](https://www.nuget.org/packages/NrsLib.CSharpToTypescriptInterface/)  

# 使い方

Converter をインスタンス化して、Convert メソッドに「変換する dll の Path」または「変換する Assembly 」と結果の変換用関数を渡してください。  
```
var converter = new Converter();  
Tuple<Type,string>[] results = converter.Convert("c:\Test.dll", Tuple.Create);  
```

変換対象は Converter.TypeExtractor を差し替えてください。  
ITypeExtractor.IsSatisfiedBy で変換するかのチェックを boolean で戻します。  
以下は string 以外の type を変換する場合の書き方です。  
```
class WithoutStringExtractor : ITypeExtractor{
	public bool IsSatisfiedBy(Type t){
		return t != typeof(string) || t != typeof(String);
	}
}
```

独自の変換が必要な場合は ITypeAdjuster を実装し、Converter.TypeAdjuster を差し替えてください。