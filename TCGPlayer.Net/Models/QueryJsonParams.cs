using Newtonsoft.Json;

namespace TCGPlayer.Net.Models
{
    public abstract class QueryJsonParams : IJsonQueryParams
	{
		public string ToJson()
		{
			return JsonConvert.SerializeObject(this);
		}
	}
}
