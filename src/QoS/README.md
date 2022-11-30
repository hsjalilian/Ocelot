# QoS

Ocelot supports one QoS (Quality of Service) capability at the current time. You can set on a per Route basis if you want to use a circuit breaker when making requests to a downstream service

Gateway launch on `localhost:8000`

## Projects 
* Gateway: this is the ocelot project launched in `http://localhost:8000` and gets incoming requests.
* ApiCustomers: sample dotnet core API project that presents Customer's data

## Get Start
From the Solution property, set startup configuration to `Multiple startup projects` and select these two project actions to `start`

After running the projects, open Below URL in Browser to see the result. 
* http://localhost:8000/customers
* http://localhost:8000/customers/1

To see the final result, call http://localhost:8000/customers/1 more than 3 times