using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Removed the duplicate eCardState enum from here

public class CardPyramid : Card {

    [Header("Set Dynamically: CardPyramid")]
    public eCardState state = eCardState.drawpile;

    // The hiddenBy List stores references to any cards that are on top of this one
    public List<CardPyramid> hiddenBy = new List<CardPyramid>();

    public int layoutID;
    public JsonLayoutSlot slotDef; // Verified against your JSON scripts

    // Intercepts the player's mouse click
    public override void OnMouseUpAsButton() {
        // Talks to YOUR specific main script (Prospector/Pyramid)
        Prospector.S.CardClicked(this);
    }
}