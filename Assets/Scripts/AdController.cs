using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdController : MonoBehaviour
{
    public float interStAdShowProbability;
    public bool testAd;
    private static InterstitialAd interstitial;

    const string interTestId = "ca-app-pub-3940256099942544/1033173712";
    const string interLiveId = "ca-app-pub-7164181614025005/7450768977";

    public void Start()
    {

        string appId = "ca-app-pub-7164181614025005~1779833417";
        MobileAds.Initialize(appId);

        RequestInterstitial();
    }

    private void RequestInterstitial()
    {
        string adUnitId;
        if (testAd)
            adUnitId = interTestId;
        else
            adUnitId = interLiveId;


        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }

    public void showInterstitialAdRaw()
    {
        if (UnityEngine.Random.Range(0, 100) < interStAdShowProbability
            && interstitial.IsLoaded())
        {
            interstitial.Show();
        }

    }

    public static void showLoadedAd(float probability)
    {
        if (UnityEngine.Random.Range(0, 100) < probability
            && interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }
}
