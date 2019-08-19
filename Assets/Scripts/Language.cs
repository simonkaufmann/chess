﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language : MonoBehaviour
{

    public static int GERMAN = 0;
    public static int ENGLISH = 1;
    public int language = GERMAN;

    GameObject txtTurnGerman;
    GameObject txtTurnEnglish;
    GameObject txtPlayerGerman;
    GameObject txtPlayerEnglish;
    GameObject buttonRestartGerman;
    GameObject buttonRestartEnglish;
    GameObject buttonGiveUpGerman;
    GameObject buttonGiveUpEnglish;
    GameObject txtRoomNameGerman;
    GameObject txtRoomNameEnglish;
    GameObject buttonJoinRoomGerman;
    GameObject buttonJoinRoomEnglish;
    GameObject txtPlayerNameGerman;
    GameObject txtPlayerNameEnglish;
    GameObject txtWelcomeGerman;
    GameObject txtWelcomeEnglish;
    GameObject txtWantRestartGerman;
    GameObject txtWantRestartEnglish;
    GameObject buttonRestartYesGerman;
    GameObject buttonRestartYesEnglish;
    GameObject buttonRestartNoGerman;
    GameObject buttonRestartNoEnglish;
    GameObject toggleWhiteGerman;
    GameObject toggleWhiteEnglish;
    GameObject toggleBlackGerman;
    GameObject toggleBlackEnglish;
    GameObject txtButtonStartGameGerman;
    GameObject txtButtonStartGameEnglish;
    GameObject txtLoadGerman;
    GameObject txtLoadEnglish;
    GameObject txtWaitForPlayerGerman;
    GameObject txtWaitForPlayerEnglish;
    GameObject txtCheckGerman;
    GameObject txtCheckEnglish;
    GameObject txtCheckmateGerman;
    GameObject txtCheckmateEnglish;
    GameObject txtWonGerman;
    GameObject txtWonEnglish;
    GameObject txtDrawGerman;
    GameObject txtDrawEnglish;
    GameObject txtPawnPromotionGerman;
    GameObject txtPawnPromotionEnglish;
    GameObject txtWantGiveUpGerman;
    GameObject txtWantGiveUpEnglish;
    GameObject buttonGiveUpYesGerman;
    GameObject buttonGiveUpYesEnglish;
    GameObject buttonGiveUpNoGerman;
    GameObject buttonGiveUpNoEnglish;
    GameObject txtWonGivenUpGerman;
    GameObject txtWonGivenUpEnglish;
    GameObject txtLostGivenUpGerman;
    GameObject txtLostGivenUpEnglish;
    void Awake()
    {
        txtTurnGerman = GameObject.Find("txtTurnGerman");
        txtTurnGerman = GameObject.Find("txtTurnGerman");
        txtTurnEnglish = GameObject.Find("txtTurnEnglish");
        txtPlayerGerman = GameObject.Find("txtPlayerGerman");
        txtPlayerEnglish = GameObject.Find("txtPlayerEnglish");
        buttonRestartGerman = GameObject.Find("buttonRestartGerman");
        buttonRestartEnglish = GameObject.Find("buttonRestartEnglish");
        buttonGiveUpGerman = GameObject.Find("buttonGiveUpGerman");
        buttonGiveUpEnglish = GameObject.Find("buttonGiveUpEnglish");
        txtRoomNameGerman = GameObject.Find("txtRoomNameGerman");
        txtRoomNameEnglish = GameObject.Find("txtRoomNameEnglish");
        buttonJoinRoomGerman = GameObject.Find("buttonJoinRoomGerman");
        buttonJoinRoomEnglish = GameObject.Find("buttonJoinRoomEnglish");
        txtPlayerNameGerman = GameObject.Find("txtPlayerNameGerman");
        txtPlayerNameEnglish = GameObject.Find("txtPlayerNameEnglish");
        txtWelcomeGerman = GameObject.Find("txtWelcomeGerman");
        txtWelcomeEnglish = GameObject.Find("txtWelcomeEnglish");
        txtWantRestartGerman = GameObject.Find("txtWantRestartGerman");
        txtWantRestartEnglish = GameObject.Find("txtWantRestartEnglish");
        buttonRestartYesGerman = GameObject.Find("buttonRestartYesGerman");
        buttonRestartYesEnglish = GameObject.Find("buttonRestartYesEnglish");
        buttonRestartNoGerman = GameObject.Find("buttonRestartNoGerman");
        buttonRestartNoEnglish = GameObject.Find("buttonRestartNoEnglish");
        toggleWhiteGerman = GameObject.Find("toggleWhiteGerman");
        toggleWhiteEnglish = GameObject.Find("toggleWhiteEnglish");
        toggleBlackGerman = GameObject.Find("toggleBlackGerman");
        toggleBlackEnglish = GameObject.Find("toggleBlackEnglish");
        txtButtonStartGameGerman = GameObject.Find("txtButtonStartGameGerman");
        txtButtonStartGameEnglish = GameObject.Find("txtButtonStartGameEnglish");
        txtLoadGerman = GameObject.Find("txtLoadGerman");
        txtLoadEnglish = GameObject.Find("txtLoadEnglish");
        txtWaitForPlayerGerman = GameObject.Find("txtWaitForPlayerGerman");
        txtWaitForPlayerEnglish = GameObject.Find("txtWaitForPlayerEnglish");
        txtCheckGerman = GameObject.Find("txtCheckGerman");
        txtCheckEnglish = GameObject.Find("txtCheckEnglish");
        txtCheckmateGerman = GameObject.Find("txtCheckmateGerman");
        txtCheckmateEnglish = GameObject.Find("txtCheckmateEnglish");
        txtWonGerman = GameObject.Find("txtWonGerman");
        txtWonEnglish = GameObject.Find("txtWonEnglish");
        txtDrawGerman = GameObject.Find("txtDrawGerman");
        txtDrawEnglish = GameObject.Find("txtDrawEnglish");
        txtPawnPromotionGerman = GameObject.Find("txtPawnPromotionGerman");
        txtPawnPromotionEnglish = GameObject.Find("txtPawnPromotionEnglish");
        txtWantGiveUpGerman = GameObject.Find("txtWantGiveUpGerman");
        txtWantGiveUpEnglish = GameObject.Find("txtWantGiveUpEnglish");
        buttonGiveUpYesGerman = GameObject.Find("buttonGiveUpYesGerman");
        buttonGiveUpYesEnglish = GameObject.Find("buttonGiveUpYesEnglish");
        buttonGiveUpNoGerman = GameObject.Find("buttonGiveUpNoGerman");
        buttonGiveUpNoEnglish = GameObject.Find("buttonGiveUpNoEnglish");
        txtWonGivenUpGerman = GameObject.Find("txtWonGivenUpGerman");
        txtWonGivenUpEnglish = GameObject.Find("txtWonGivenUpEnglish");
        txtLostGivenUpGerman = GameObject.Find("txtLostGivenUpGerman");
        txtLostGivenUpEnglish = GameObject.Find("txtLostGivenUpEnglish");
    }

    // Update is called once per frame
    void Update()
    {
        if (language == Language.GERMAN)
        {
            txtTurnGerman.SetActive(true);
            txtTurnEnglish.SetActive(false);
            txtPlayerGerman.SetActive(true);
            txtPlayerEnglish.SetActive(false);
            buttonRestartGerman.SetActive(true);
            buttonRestartEnglish.SetActive(false);
            buttonGiveUpGerman.SetActive(true);
            buttonGiveUpEnglish.SetActive(false);
            txtRoomNameGerman.SetActive(true);
            txtRoomNameEnglish.SetActive(false);
            buttonJoinRoomGerman.SetActive(true);
            buttonJoinRoomEnglish.SetActive(false);
            txtPlayerNameGerman.SetActive(true);
            txtPlayerNameEnglish.SetActive(false);
            txtWelcomeGerman.SetActive(true);
            txtWelcomeEnglish.SetActive(false);
            txtWantRestartGerman.SetActive(true);
            txtWantRestartEnglish.SetActive(false);
            buttonRestartYesGerman.SetActive(true);
            buttonRestartYesEnglish.SetActive(false);
            buttonRestartNoGerman.SetActive(true);
            buttonRestartNoEnglish.SetActive(false);
            toggleWhiteGerman.SetActive(true);
            toggleWhiteEnglish.SetActive(false);
            toggleBlackGerman.SetActive(true);
            toggleBlackEnglish.SetActive(false);
            txtButtonStartGameGerman.SetActive(true);
            txtButtonStartGameEnglish.SetActive(false);
            txtLoadGerman.SetActive(true);
            txtLoadEnglish.SetActive(false);
            txtWaitForPlayerGerman.SetActive(true);
            txtWaitForPlayerEnglish.SetActive(false);
            txtCheckGerman.SetActive(true);
            txtCheckEnglish.SetActive(false);
            txtCheckmateGerman.SetActive(true);
            txtCheckmateEnglish.SetActive(false);
            txtWonGerman.SetActive(true);
            txtWonEnglish.SetActive(false);
            txtDrawGerman.SetActive(true);
            txtDrawEnglish.SetActive(false);
            txtPawnPromotionGerman.SetActive(true);
            txtPawnPromotionEnglish.SetActive(false);
            txtWantGiveUpGerman.SetActive(true);
            txtWantGiveUpEnglish.SetActive(false);
            buttonGiveUpYesGerman.SetActive(true);
            buttonGiveUpYesEnglish.SetActive(false);
            buttonGiveUpNoGerman.SetActive(true);
            buttonGiveUpNoEnglish.SetActive(false);
            txtWonGivenUpGerman.SetActive(true);
            txtWonGivenUpEnglish.SetActive(false);
            txtLostGivenUpGerman.SetActive(true);
            txtLostGivenUpEnglish.SetActive(false);
        } else
        {
            txtTurnGerman.SetActive(false);
            txtTurnEnglish.SetActive(true);
            txtPlayerGerman.SetActive(false);
            txtPlayerEnglish.SetActive(true);
            buttonRestartGerman.SetActive(false);
            buttonRestartEnglish.SetActive(true);
            buttonGiveUpGerman.SetActive(false);
            buttonGiveUpEnglish.SetActive(true);
            txtRoomNameGerman.SetActive(false);
            txtRoomNameEnglish.SetActive(true);
            buttonJoinRoomGerman.SetActive(false);
            buttonJoinRoomEnglish.SetActive(true);
            txtPlayerNameGerman.SetActive(false);
            txtPlayerNameEnglish.SetActive(true);
            txtWelcomeGerman.SetActive(false);
            txtWelcomeEnglish.SetActive(true);
            txtWantRestartGerman.SetActive(false);
            txtWantRestartEnglish.SetActive(true);
            buttonRestartYesGerman.SetActive(false);
            buttonRestartYesEnglish.SetActive(true);
            buttonRestartNoGerman.SetActive(false);
            buttonRestartNoEnglish.SetActive(true);
            toggleWhiteGerman.SetActive(false);
            toggleWhiteEnglish.SetActive(true);
            toggleBlackGerman.SetActive(false);
            toggleBlackEnglish.SetActive(true);
            txtButtonStartGameGerman.SetActive(false);
            txtButtonStartGameEnglish.SetActive(true);
            txtLoadGerman.SetActive(false);
            txtLoadEnglish.SetActive(true);
            txtWaitForPlayerGerman.SetActive(false);
            txtWaitForPlayerEnglish.SetActive(true);
            txtCheckGerman.SetActive(false);
            txtCheckEnglish.SetActive(true);
            txtCheckmateGerman.SetActive(false);
            txtCheckmateEnglish.SetActive(true);
            txtWonGerman.SetActive(false);
            txtWonEnglish.SetActive(true);
            txtDrawGerman.SetActive(false);
            txtDrawEnglish.SetActive(true);
            txtPawnPromotionGerman.SetActive(false);
            txtPawnPromotionEnglish.SetActive(true);
            txtWantGiveUpGerman.SetActive(false);
            txtWantGiveUpEnglish.SetActive(true);
            buttonGiveUpYesGerman.SetActive(false);
            buttonGiveUpYesEnglish.SetActive(true);
            buttonGiveUpNoGerman.SetActive(false);
            buttonGiveUpNoEnglish.SetActive(true);
            txtWonGivenUpGerman.SetActive(false);
            txtWonGivenUpEnglish.SetActive(true);
            txtLostGivenUpGerman.SetActive(false);
            txtLostGivenUpEnglish.SetActive(true);
        }
    }
}
