# Sample Azure Function

## Setup

### The simple way

To create the solution you first need to install this template
```bash
dotnet new install Microsoft.Azure.Functions.Templates
```

And now you can use create a new project with cli
```bash
dotnet new func
```

## The hard way

This way allows to create more complex functions with a kit of azure.

To excecute Azure Function Core Tools, for my case I had to download [Azure function core tools](https://github.com/Azure/azure-functions-core-tools?tab=readme-ov-file#other-linux-distributions)


If you want to add it to path, use commands bellow:
```bash
sudo mv azure-functions-cli /usr/azure/functions-cli
```

```bash
sudo nano ~/.bashrc
```

Then type the path of your tool kit
```bash
export PATH="$PATH:/usr/azure-functions-cli"
```

Then run the coniguration
```bash
source ~/.bashrc
```

Check func is added to PATH
```bash
which func
```

## Create a project 

Now you can use this commands to create your own [Azure Function Project](https://learn.microsoft.com/en-us/azure/azure-functions/create-first-function-cli-csharp?tabs=linux%2Cazure-cli)

Create a project with default config:
```bash
func init MiNuevoProyecto --dotnet
```

Create a new project with target framework:
```bash
func init LocalFunctionProj --worker-runtime dotnet-isolated --target-framework net8.0
```

## Create functions

func new 
```bash
func new --name MyHttpFunction --template "HttpTrigger"
```


The types you can create are:
- `HttpTrigger`
- `BlobTrigger`
- `QueueTrigger`
- `TimerTrigger`
- `EventGridTrigger`
- `EventHubTrigger`
- `CosmosDBTrigger`
- `ServiceBusQueueTrigger`
- `ServiceBusTopicTrigger`
- `DurableFunctionsActivity`
- `DurableFunctionsOrchestrator`
- `DurableFunctionsEntity`
- `IoTHubTrigger`
- `SignalRTrigger`

Also you can use `func new` to have a console wizzard

## Run Azure fucnton

To run locally, use:
```bash
func start
```