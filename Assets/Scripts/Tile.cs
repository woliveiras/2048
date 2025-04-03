using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tile : MonoBehaviour
{
  public TileState state { get; private set; }
  public TileCell cell { get; private set; }
  public int number { get; private set; }
  private Image background;
  private TextMeshProUGUI text;

  private void Awake()
  {
    background = GetComponent<Image>();
    text = GetComponentInChildren<TextMeshProUGUI>();
  }

  public void SetState(TileState state, int number)
  {
    this.state = state;
    this.number = number;
    background.color = state.backgroundColor;
    text.color = state.textColor;
    text.text = number.ToString();
  }

  public void Spawn(TileCell cell)
  {
    if (this.cell != null)
    {
      this.cell.tile = null;
    }

    this.cell = cell;
    this.cell.tile = this;
    transform.position = cell.transform.position;
  }
}
