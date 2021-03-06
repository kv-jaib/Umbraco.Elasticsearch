using Nest;

namespace Umbraco.Elasticsearch.Samplev74.Features.Search.Queries.Image
{
    [ElasticType(Name = "image", IdProperty = "Id")]
    public class ImageDocument : UmbracoDocument
    {
        public string Extension { get; set; }
        public long Size { get; set; }
    }
}