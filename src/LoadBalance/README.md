# Load Balance Template

This template routes requests between two same services. in the real world, one service deploys in multi servers.

Gateway launch on `localhost:8000`

## Projects 
* Gateway: this is the ocelot project launched in `http://localhost:8000` and gets incoming requests.
* ApiCustomersA: sample dotnet core API project that presents Customer's data
* ApiCustomersB: sample dotnet core API project that presents Customer's data

## Get Start
From the Solution property, set startup configuration to `Multiple startup projects` and select these three project actions to `start`

After running the projects, open Below URL in Browser to see the result. attend to `From Server ...` in response!
* http://localhost:8000/cutomers
* http://localhost:8000/cutomers/0