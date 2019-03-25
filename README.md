# Activity Streams

This repo contains a .NET Standard 2.0 implementation of the [W3C Activity Streams specification](https://www.w3.org/TR/2017/REC-activitystreams-vocabulary-20170523/#introduction).

## Work In Progress

A couple quick notes regarding this library:

- This is a work-in-progress and may not currently adhere 100% to the spec.
- There are likely to be breaking changes in the future as the implementation is refined - so use at your own risk.
- Significant overriding of the default Newtonsoft.Json JsonConverter was required to serialize/deserialize according to the JSON-LD/Activity Streams spec.
- The aforementioned customization likely negatively impact serialization/deserialization performance.
- This was written in brute-force manner. Goal was to get it to work broadly and then go back and improve performance.
- There are 320 unit tests validating the serialization/deserialization of this library against the examples provided on the Activity Streams vocabulary website. These tests are all green, but may not account for your scenarios. Please file a bug if you encounter something that should work but doesn't.

## Usage

You must specify the `ActivityStreamsConverter` in the `JsonSerializerSettings` in order to property serialize/deserialize JSON content.

For example:

```CSharp
JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
{
    Converters = new List<JsonConverter>()
    {
        new ActivityStreamsConverter()
    }
};

var result = JsonConvert.DeserializeObject<ActivityStreamsObject>(json, SerializerSettings);
```

See the `ActivityStreams.Primitives.Tests` project for a full set of examples.

## Pull Requests

As always, pull requests are welcomed.

## License

This project is licensed under the MIT license.

There are code files in use from the [Schema.NET](https://github.com/RehanSaeed/Schema.NET/tree/master/Source/Schema.NET) project and those files carry forward MIT license from that project.