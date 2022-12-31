using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ServerModels;
public class BanHammer : MonoBehaviour
{
    public string playerId;
   

    void OnTriggerEnter(Collider other)
    {
        //function or event goes here
        AddBan(playerId);
        Application.Quit();
    }
    void AddBan(string playerid)
    {
        PlayFabServerAPI.BanUsers(new BanUsersRequest()
        {
            Bans = new List<BanRequest>() {
            new BanRequest() {
                DurationInHours = 10000000,
                PlayFabId = playerId,
                Reason = "Breaking SomeThing bad ",
            }
        }
        }, result => {
            //... Handle success
        }, error => {
            Debug.Log(error.GenerateErrorReport());

        });
    }
}