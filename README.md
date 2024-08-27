# Sample Azure Function

## Setup

To create the solution you first need to install
```bash
dotnet new install Microsoft.Azure.Functions.Templates
```

And now you can use
```bash
dotnet new func
```

To excecute Azure Function Core Tools, for my case I had to download [](https://github.com/Azure/azure-functions-core-tools?tab=readme-ov-file#other-linux-distributions)

Then you use this commands to create your own [Azure Function Project](https://learn.microsoft.com/en-us/azure/azure-functions/create-first-function-cli-csharp?tabs=linux%2Cazure-cli)

If you want to add it to path, use this commands
```bash
sudo mv azure-functions-cli /usr/azure/functions-cli
```

```bash
sudo nano ~/.bashrc
```

```bash
source ~/.bashrc
```

```bash
export PATH="$PATH:/usr/azure-functions-cli"
```

```bash
which func
```

Now you are able to crate several types of functions
## Create project
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

To run locally, use
```bash
func start
```