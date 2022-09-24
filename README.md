# .NET mutation tests

## References
  - [Stryker .NET](https://stryker-mutator.io/docs/stryker-net/introduction/)
  - [Stryker dashboard](https://dashboard.stryker-mutator.io/)

## Install

### Global
```bash
dotnet tool install -g dotnet-stryker
```


### In projecto

#### Configure manifest
```bash
dotnet new tool-manifest
```

#### Install stryker
```bash
dotnet tool install dotnet-stryker
```



## How can run?

```bash
dotnet stryker -tp <path> --reporter <type> --dashboard-api-key <key> --open-report
```
* `-tp <path>`: Test project
* `--reporter <type>`: Type of reporter [ cleartext | progress | html | json | dashboard | all ]
  * `ClearText`: Show report in console
  * `Progress`: Show the progress ins console
  * `html`: Generate a html report
  * `json`: Generate a json report
  * `dashboard`: Send report to cloud dashboard
* `--dashboard-api-key`: Api key for dashboard
* `--open-report` or `-o`: Open report in browser when is done

### E.g
***Basic command***
```bash
dotnet stryker
```

***Open report when is done***
```bash
dotnet stryker -tp tests/Demo.Tests.csproj -o
```

***show the report in console and the progress***
```bash
dotnet stryker -tp tests/Demo.Tests.csproj --reporter cleartext --reporter progress
```

***Generate json and html report***
```bash
dotnet stryker -tp tests/Demo.Tests.csproj --reporter json --reporter html
```



## CI/CD

[![Mutation testing badge](https://img.shields.io/endpoint?style=flat&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2Fgithub.com%2FNelsonBN%2Fdemo-dotnet-mutation-tests%2Fmain)](https://dashboard.stryker-mutator.io/reports/github.com/NelsonBN/demo-dotnet-mutation-tests/main)

### E.g
```yml
- name: "Test"
  run: dotnet stryker -tp tests/**/*.Tests.csproj --reporter dashboard --dashboard-api-key ${{ secrets.STRYKER_API_KEY }}
```