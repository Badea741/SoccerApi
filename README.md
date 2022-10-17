# Soccer secure api

###### to run
``` cli
docker compose up -d
```
## Add this configuration in the cli from the base directory

``` cli
cd Soccer.Shared/
dotnet user-secrets init
dotnet user-secrets set "AdminPassword" "<pass>" #without <> in the directory of Soccer.Shared
```

