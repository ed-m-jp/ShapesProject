using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Shapes.Base;

namespace Shapes
{
    public static class ShapeJsonSerializer
    {
        public static (bool, string) ShapeCollectionToJson(IEnumerable<Shape> collection)
        {
            try
            {
                var json = JsonConvert.SerializeObject(collection,
                    new JsonSerializerSettings { FloatFormatHandling = FloatFormatHandling.DefaultValue });

                return (true, json);
            }
            catch (Exception e)
            {
                return (false, e.Message);
            }
        }
    }
}
