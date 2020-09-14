# TemplateGenerator

Template Generator for generate code

Combine generate the possible combinations of all sets

Cooperate with Some String process method will be powerful

This is part of [CWKSC/MyLib_Csharp](https://github.com/CWKSC/MyLib_Csharp) C# library 

If you already include this library, its functionality is already included

Note that there are some extension methods for printing on Demo

For example: `"42".Print() == Console.Write("42")`, `"42".Printlnln() == Console.WriteLine("42" + "\n");`

### Basic Usage

```c#
// string Generate(string template, params string[][] set) //
string template = "<0> <1> <2>\n";

string[] set0 = { "12", "34" };
string[] set1 = { "xx", "yy", "zz" };
string[] set2 = { "aa", "bb", "cc", "dd" };

Generate(template, set0, set1, set2).Println();
```

#### Output:

```c#
12 xx aa
12 xx bb
12 xx cc
12 xx dd
12 yy aa
12 yy bb
12 yy cc
12 yy dd
12 zz aa
12 zz bb
12 zz cc
12 zz dd
34 xx aa
34 xx bb
34 xx cc
34 xx dd
34 yy aa
34 yy bb
34 yy cc
34 yy dd
34 zz aa
34 zz bb
34 zz cc
34 zz dd
```

### GenerateByGroup

```csharp
// string GenerateByGroup(string template, params string[][][] groups) //
string template_group = "<0_0> <0_1> <1_0>\n";

string[] group0_set0 = { "12", "34", "56" };
string[] group0_set1 = { "xx", "yy", "zz" };
string[] group1_set0 = { "aa", "bb", "cc", "dd" };
string[][] group0 = { group0_set0, group0_set1 };
string[][] group1 = { group1_set0 };

GenerateByGroup(template_group, group0, group1).Println();
```

#### Output:

```c#
12 xx aa
12 xx bb
12 xx cc
12 xx dd
34 yy aa
34 yy bb
34 yy cc
34 yy dd
56 zz aa
56 zz bb
56 zz cc
56 zz dd
```

### Another example of GenerateByGroup

```csharp
string template =
@"public static double CartesianToPolar_<1_0>(<0_0>) {
double result = Math.Atan2(<0_1>);
return (result < 0 ? result + TwoPI : result) * <1_1>;
}
";

// Group0 set //
string[] group0_set0_parameter_args = {
	"double x, double y",
	"Vector2 point",
	"List<double> list" };
string[] group0_set1_ATan2_input_parameter = {
	"y, x",
	"point.Y, point.X",
	"list[1], list[0]" };

// Group1 set //
string[] group1_set0_type = {
	"Radians",
	"Degrees",
	"Gradians"
};
string[] group1_set1_convert = {
	"1",
	"RadToDeg",
	"RadToGrad"
};

// Group //
string[][] group0 = {
	group0_set0_parameter_args,
	group0_set1_ATan2_input_parameter
};
string[][] group1 = {
	group1_set0_type,
	group1_set1_convert
};

GenerateByGroup(template, group0, group1).Printlnln();
```

#### Output:

```csharp
public static double CartesianToPolar_Radians(double x, double y) {
    double result = Math.Atan2(y, x);
    return (result < 0 ? result + TwoPI : result) * 1;
}
public static double CartesianToPolar_Degrees(double x, double y) {
    double result = Math.Atan2(y, x);
    return (result < 0 ? result + TwoPI : result) * RadToDeg;
}
public static double CartesianToPolar_Gradians(double x, double y) {
    double result = Math.Atan2(y, x);
    return (result < 0 ? result + TwoPI : result) * RadToGrad;
}
public static double CartesianToPolar_Radians(Vector2 point) {
    double result = Math.Atan2(point.Y, point.X);
    return (result < 0 ? result + TwoPI : result) * 1;
}
public static double CartesianToPolar_Degrees(Vector2 point) {
    double result = Math.Atan2(point.Y, point.X);
    return (result < 0 ? result + TwoPI : result) * RadToDeg;
}
public static double CartesianToPolar_Gradians(Vector2 point) {
    double result = Math.Atan2(point.Y, point.X);
    return (result < 0 ? result + TwoPI : result) * RadToGrad;
}
public static double CartesianToPolar_Radians(List<double> list) {
    double result = Math.Atan2(list[1], list[0]);
    return (result < 0 ? result + TwoPI : result) * 1;
}
public static double CartesianToPolar_Degrees(List<double> list) {
    double result = Math.Atan2(list[1], list[0]);
    return (result < 0 ? result + TwoPI : result) * RadToDeg;
}
public static double CartesianToPolar_Gradians(List<double> list) {
    double result = Math.Atan2(list[1], list[0]);
    return (result < 0 ? result + TwoPI : result) * RadToGrad;
}
```

### GenerateByName

```csharp
// GenerateByName //
string template_byName = "<type> <varname><suffix>;\n";

(string, string[]) typeSet = ("type", new string[] { "int", "string", "bool", "double" });
(string, string[]) varnameSet = ("varname", new string[] { "x", "y", "z" });
(string, string[]) suffixSet = ("suffix", new string[] { "1", "2", "3" });

GenerateByName(template_byName, typeSet, varnameSet, suffixSet).Printlnln();
```

#### Output:

```csharp
int x1;
int x2;
int x3;
int y1;
int y2;
int y3;
int z1;
int z2;
int z3;
string x1;
string x2;
string x3;
string y1;
string y2;
string y3;
string z1;
string z2;
string z3;
bool x1;
bool x2;
bool x3;
bool y1;
bool y2;
bool y3;
bool z1;
bool z2;
bool z3;
double x1;
double x2;
double x3;
double y1;
double y2;
double y3;
double z1;
double z2;
double z3;
```

### GenerateByName generate generic class

```csharp
// GenerateByName generate generic class //
string template_byName2 = "class Box<<generic>> { }\n";

(string, string[]) genericSet = ("generic", "T".ToConcatUpperTriangular_SeparateBy(5, ", "));

GenerateByName(template_byName2, genericSet).Printlnln();
```

#### Output:

```csharp
class Box<T> { }
class Box<T, T> { }
class Box<T, T, T> { }
class Box<T, T, T, T> { }
class Box<T, T, T, T, T> { }
```

