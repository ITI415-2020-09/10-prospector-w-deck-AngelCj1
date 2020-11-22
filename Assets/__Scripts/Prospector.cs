﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Prospector : MonoBehaviour {

	static public Prospector 	S;

	[Header("Set in Inspector")]
	public TextAsset			deckXML;


	[Header("Set Dynamically")]
	public Deck					deck;

	void Awake(){
		S = this;
	}

	void Start() {
		deck = GetComponent<Deck> ();	// Get the Deck
		deck.InitDeck (deckXML.text);   // Pass DeckXML to it
		Deck.Shuffle(ref deck.cards);	// This shuffles the deck
		// The ref keyword passed a reference to deck.cards, which allows
		// deck.cards to be modified by Deck.Shuffle()
	}

}
