using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKCSharp;
using OKCSharp.Objects;
using OKCSharp.Search;
using System.Linq;
using System.Threading.Tasks;

namespace OKCSharpTests
{
    [TestClass]
    public class MainTests
    {
        private OKCSharpClient Client { get; set; }

        public MainTests() => this.Client = new OKCSharpClient("", "");

        [TestMethod]
        public async Task TestMessageState() => Assert.IsNotNull(await this.Client.GetMessageStateAsync());

        [TestMethod]
        public async Task TestGetMatches() => Assert.IsNotNull(await this.Client.GetDiscoveryMatchesAsync(DiscoverySection.match_search_smoking, 1));

        [TestMethod]
        public async Task TestGetUserProfileAsync()
        {
            var data = await this.Client.GetDiscoveryMatchesAsync(DiscoverySection.match_search_smoking, 1);
            Assert.IsNotNull(await this.Client.GetUserProfileAsync(data.First().UserId));
        }

        [TestMethod]
        public async Task TestSwipeAsync()
        {
            var data = await this.Client.GetDiscoveryMatchesAsync(DiscoverySection.match_search_smoking, 1);
            Assert.IsNotNull(await this.Client.SwipeAsync(SwipeType.Like, data.First().UserId));
        }

        [TestMethod]
        public async Task TestSearchAsync() => Assert.IsNotNull(await this.Client.SearchUsersAsync(new SearchPayload()
        {
            TheyWant = "Men",
            IWant = "Women",
            MaximumAge = 25,
            MinimumAge = 18,
            LocatedAnywhere = true,
            Availability = "single",
            Radius = 500,
            Location = new SearchLocation()
            {
                CityName = "London",
                CountryCode = "UK",
                CountryName = "United Kingdom",
                Longitude = 51.5074F,
                Latitude = 0.1278F
            }
        }));

        /*[TestMethod]
        public async Task TestUserLikes() => Assert.IsNotNull(await this.Client.GetUserLikesAsync());

        [TestMethod]
        public async Task TestUserProfile() => Assert.IsNotNull(await this.Client.GetCurrentUserProfileAsync());*/
    }
}
