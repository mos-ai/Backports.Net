# BackPorts.NET

This repository is for porting .net libraries back to .netstandard2.0

Ported Libraries
|--|--|
| Library | State |
|--|--|
| System.IO.Pipes | Working |

## Notes:

For now use using statements and alias the assembly to use the backfilled library and ifdef them to be for .netstandard2.0 to make it forward compatible.

```C#
#if NETSTANDARD2.0
using PipeStream = System.IO.Pipes.PipeStream;
using PipeOptions = System.IO.Pipes.PipeOptions;
...
```

For now targeting windows only, might restore unix later if I have a need or someone contributes.

## Library Specific Information

### System.IO.Pipes

Nothing for now.