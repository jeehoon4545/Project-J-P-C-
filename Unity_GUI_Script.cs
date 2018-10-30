using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cs_TitleMenu : MonoBehaviour {
	//#######################
	/*  UI Object Setting */
	//#######################

	// Title GUI.
	public GameObject Title_IMG;				// Title_menu_IMG Object

	// GameStart Button Show GUI.
	public GameObject GameStart_IMG;		// GameStart_menu_IMG Object

	// Option GUI.
	public Text UI_NAME;				// UI 선택시, 해당 이름 변경.
	public GameObject UI_GAME;
	public GameObject UI_CONTROL;
	public GameObject UI_VIDEO;

	public GameObject UI_GAME_btn_difficulty_normal;	// Difficulty Button (Normal, Hard)
	public GameObject UI_GAME_btn_difficulty_hard;
	public GameObject UI_GAME_btn_UI_TIP_onoff;			// Tip on,off Button
	public GameObject UI_GAME_slider_Volume; 			// Volume Slider

	// 카메라 오브젝트.
	public Animator CameraObject; 			// Animator CameraObject

	//#######################
	/*  UI Control Setting */
	//#######################

	// 게임시작 버튼 클릭시.
	public void PlayGame_on()
	{
		GameStart_IMG.gameObject.active = true;		// GameStart_Menu_Img 활성화.
	}

	// PlayGame_on 비활성화.
	public void PlayGame_off()
	{
		GameStart_IMG.gameObject.active = false;	// GameStart_Menu_Img 비활성화.
	}

	// Option Button Click
	public void Option_on()
	{
		CameraObject.SetBool ("option_clk", true);	// Animator Run (Move Camera Pos)
	}

	// Back Button Click
	public void Option_off()
	{
		CameraObject.SetBool ("option_clk", false); 	// Animator Run (Move Camera Pos) 
	}

	// Option UI Setting
	public void UI_GAME_SHOW()
	{
		// GAME UI Show
		UI_GAME.gameObject.active = true;			// Option -> Game Button Clicks  Show UI
		UI_NAME.text = "GAME";		// NickName Show
		// 기타 UI 버튼 등 표시.
		UI_GAME_btn_difficulty_hard.gameObject.active = true;
		UI_GAME_btn_difficulty_normal.gameObject.active = true;
		UI_GAME_btn_UI_TIP_onoff.gameObject.active = true;
		UI_GAME_slider_Volume.gameObject.active = true;

		// other HIDE
		UI_CONTROL_HIDE();
		UI_VIDEO_HIDE ();
	}
	public void UI_GAME_HIDE()
	{
		// GAME UI HIDE
		UI_GAME.gameObject.active = false;			// Option -> Not Game Button Clicks  HIDE UI

		// 기타 UI 버튼 등 감추기.
		UI_GAME_btn_difficulty_hard.gameObject.active = false;
		UI_GAME_btn_difficulty_normal.gameObject.active = false;
		UI_GAME_btn_UI_TIP_onoff.gameObject.active = false;
		UI_GAME_slider_Volume.gameObject.active= false;

	}

	public void UI_CONTROL_SHOW()
	{
		// Control UI SHOW
		UI_CONTROL.gameObject.active = true;
		UI_NAME.text = "CNT";

		// 기타 UI 버튼 등 표시.

		// other HIDE
		UI_GAME_HIDE();
		UI_VIDEO_HIDE ();
	}
	public void UI_CONTROL_HIDE()
	{
		// Control UI HIDE
		UI_CONTROL.gameObject.active = false;

		// 기타 UI 버튼 등 감추기.

	}

	public void UI_VIDEO_SHOW()
	{
		// VIDEO UI SHOW
		UI_VIDEO.gameObject.active = true;
		UI_NAME.text = "VIDEO";

		// other HIDE
		UI_GAME_HIDE();
		UI_CONTROL_HIDE ();
	}

	public void UI_VIDEO_HIDE()
	{
		// VIDEO UI HIDE
		UI_VIDEO.gameObject.active = false;

	}
}
