using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using CelebritiesSystem;
using CelebritiesSystem.Services;

public class ScraperServiceMock : IScraperService
{
    public async Task<ArrayList> ScrapeCelebritiesUrlsList()
    {
        ArrayList mocksUrl = new ArrayList();
        mocksUrl.Add("https://www.imdb.com/name/nm0000230/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000226/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000142/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000139/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000123/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000229/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000148/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000134/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000199/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000375/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000128/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000553/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000701/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000242/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000204/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000112/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000125/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0089217/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0425005/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000329/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0001401/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0001191/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0424060/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0005132/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0004266/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0004695/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0001570/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0461136/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0177896/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0002071/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000210/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000115/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0185819/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000206/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0005212/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000932/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000246/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000168/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0001774/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000169/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000104/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000243/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0136797/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0479471/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm1083271/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0290556/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000154/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0004874/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000741/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000245/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000228/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0004755/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0005405/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000241/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0302108/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0005562/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000288/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0001392/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000113/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000045/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000106/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000346/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000197/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000195/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000244/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0350453/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0352032/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0005458/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0001472/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000295/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000100/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000008/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000237/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm1475594/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000255/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0451321/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000098/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm1297015/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm1165110/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0564215/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000116/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000821/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000409/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm1046097/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm1089991/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0451148/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0707425/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000136/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000216/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000120/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0914612/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0705356/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000138/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000129/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000093/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000122/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000151/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000158/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0413168/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000354/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000230/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000226/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000142/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000139/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000123/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000229/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000148/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000134/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000199/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000375/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000128/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000553/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000701/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000242/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000204/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000112/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000125/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0089217/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0425005/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000329/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0001401/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0001191/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0424060/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0005132/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0004266/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0004695/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0001570/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0461136/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0177896/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0002071/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000210/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000115/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0185819/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000206/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0005212/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000932/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000246/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000168/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0001774/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000169/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000104/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000243/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0136797/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0479471/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm1083271/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0290556/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000154/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0004874/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000741/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000245/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000228/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0004755/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0005405/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000241/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0302108/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0005562/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000288/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0001392/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000113/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000045/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000106/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000346/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000197/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000195/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000244/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0350453/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0352032/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0005458/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0001472/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000295/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000100/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000008/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000237/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm1475594/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000255/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0451321/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000098/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm1297015/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm1165110/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0564215/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000116/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000821/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0000409/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm1046097/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm1089991/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0451148/?ref_=nmls_pst");
        mocksUrl.Add("https://www.imdb.com/name/nm0707425/?ref_=nmls_pst");

        return mocksUrl;
    }

    public Task<CelebrityResponseDto> ScrapeCelebritiesDetailsByUrl(string url)
    {
        throw new System.NotImplementedException();
    }

    public Task InitializeData()
    {
        throw new System.NotImplementedException();
    }
}