using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class moveTOCheckPoint : MonoBehaviour, IUnityAdsListener
{

    public GameObject player;

    string mySurfacingId = "Rewarded_Android";

    public void moveToCP()
    {
        adCLick();
        // if sucessfull
        goToCP();
    }

    private void goToCP()
    {
        //Time.timeScale = 1;
        globalV.gameOver = false;

        player.transform.position = new Vector2(globalV.lastPos_x, globalV.lastPos_y);

    }

    

    private void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(globalV.adID, globalV.testMode);
    }

    // Start is called before the first frame update
    public void adCLick()
    {
        //
        ShowRewardedVideo();
        //adM.text = "No Ads";


    }

    private void Update()
    {
        if (Advertisement.IsReady())
        {
            //adM.color = adR;
            //adM.text = "Ad Ready :)";
        }
        else
        {
            //adM.color = adNotR;
            //adM.text = "Ad not ready";
        }
    }


    public void ShowRewardedVideo()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(mySurfacingId))
        {
            Advertisement.Show(mySurfacingId);
        }
        else
        {
            //adM.text = "No Ads";
            //Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string surfacingId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            goToCP();
            // Reward the user for watching the ad to completion.
        }
        else if (showResult == ShowResult.Skipped)
        {
            goToCP();
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            //adM.text = "Ad Failed";
            //Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady(string surfacingId)
    {
        // If the ready Ad Unit or legacy Placement is rewarded, show the ad:
        if (surfacingId == mySurfacingId)
        {
            //Debug.Log("ready");
            //adM.text = "Ad Ready";
            // Optional actions to take when theAd Unit or legacy Placement becomes ready (for example, enable the rewarded ads button)
        }
        else
        {
            //adM.text = "No Ads";
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string surfacingId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }



    private void OnDestroy()
    {
        Advertisement.RemoveListener(this);
    }

}
