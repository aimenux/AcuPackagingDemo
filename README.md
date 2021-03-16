# AcuPackagingDemo
```
Packaging acumatica dlls to nuget feed source
```

> In this repo, i m providing 2 projects (class library and console application) :
>
>> :one: In `AcuPackagingLib`, i m using github actions in order to package acumatica dlls for both versions 20R1 and 20R2 then push them to [nuget.org](https://www.nuget.org/).
>>
>> :two: In `AcuPackagingApp`, i m using the generated package [Acu20R2-200.nupkg](https://www.nuget.org/packages/Acu20R2-200/) in order to illustrate the use of BQL in a console application.
>
>
> Nugets are generated for versions :
>
>> :pushpin: [20R1-112](https://www.nuget.org/packages/Acu20R1-112/)
>>
>> :pushpin: [20R2-200](https://www.nuget.org/packages/Acu20R2-200/)
>

**`Tools`** : vs19, net framework 4.8, acumatica