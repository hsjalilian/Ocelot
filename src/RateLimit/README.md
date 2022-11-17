# RateLimit

This template, handle client request limitation in custom periodic time per endpoint.

Gateway launch on `localhost:8000`

## Projects 
* Gateway: this is the ocelot project launched in `http://localhost:8000` and gets incoming requests.
* ApiCustomers: sample dotnet core API project that presents Customer's data

## Get Start
From the Solution property, set startup configuration to `Multiple startup projects` and select these three project actions to `start`

After running the projects, open Below URL in Browser to see the result.
* http://localhost:8000/cutomers
* http://localhost:8000/cutomers/0