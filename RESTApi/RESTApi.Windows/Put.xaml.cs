using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RESTApi
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class Put : Page
  {
    public Put()
    {
      this.InitializeComponent();
    }

    public async void PostData()
    {
      var httpClient = new HttpClient(new HttpClientHandler());
      HttpRequestHeaders headers = httpClient.DefaultRequestHeaders;
      HttpResponseMessage response = await httpClient.DeleteAsync("http://movieapp123.azurewebsites.net/api/Actors/4");
      response.EnsureSuccessStatusCode();
      string responseAsText = await response.Content.ReadAsStringAsync();
      Debug.WriteLine(responseAsText);
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
PostData();
    }
  }
}
