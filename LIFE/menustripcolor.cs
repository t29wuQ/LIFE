﻿using System.Windows.Forms;
using System.Drawing;

class VS2012ColorTable : ProfessionalColorTable
{

    public VS2012ColorTable()
    {
        this.UseSystemColors = false;
    }

    // ボタンがオンの場合に使用するグラデーションの開始色を取得します。
    public override Color ButtonCheckedGradientBegin { get { return Color.FromArgb(0, 0, 0); } }
    // ボタンがオンの場合に使用するグラデーションの終了色を取得します。
    public override Color ButtonCheckedGradientEnd { get { return Color.FromArgb(0, 0, 0); } }
    // ボタンがオンの場合に使用するグラデーションの中間色を取得します。
    public override Color ButtonCheckedGradientMiddle { get { return Color.FromArgb(0, 0, 0); } }
    // ボタンがオンの場合に使用する純色を取得します。
    public override Color ButtonCheckedHighlight { get { return Color.FromArgb(196, 225, 255); } }
    // ButtonCheckedHighlight で使用する境界線の色を取得します。
    public override Color ButtonCheckedHighlightBorder { get { return Color.FromArgb(51, 153, 255); } }
    // ButtonPressedGradientBegin、 ButtonPressedGradientMiddle、および ButtonPressedGradientEnd の各色で使用する境界線の色を取得します。
    public override Color ButtonPressedBorder { get { return Color.FromArgb(51, 153, 255); } }
    // ボタンが押されている場合に使用するグラデーションの開始色を取得します。
    public override Color ButtonPressedGradientBegin { get { return Color.FromArgb(153, 204, 255); } }
    // ボタンが押されている場合に使用するグラデーションの終了色を取得します。
    public override Color ButtonPressedGradientEnd { get { return Color.FromArgb(153, 204, 255); } }
    // ボタンが押されている場合に使用するグラデーションの中間色を取得します。
    public override Color ButtonPressedGradientMiddle { get { return Color.FromArgb(153, 204, 255); } }
    // ボタンが押されている場合に使用する純色を取得します。
    public override Color ButtonPressedHighlight { get { return Color.FromArgb(152, 203, 255); } }
    // ButtonPressedHighlight で使用する境界線の色を取得します。
    public override Color ButtonPressedHighlightBorder { get { return Color.FromArgb(51, 153, 255); } }
    // ButtonSelectedGradientBegin、 ButtonSelectedGradientMiddle、および ButtonSelectedGradientEnd の各色で使用する境界線の色を取得します。
    public override Color ButtonSelectedBorder { get { return Color.FromArgb(51, 153, 255); } }
    // ボタンがオンの場合に使用するグラデーションの開始色を取得します。
    public override Color ButtonSelectedGradientBegin { get { return Color.FromArgb(194, 224, 255); } }
    // ボタンがオンの場合に使用するグラデーションの終了色を取得します。
    public override Color ButtonSelectedGradientEnd { get { return Color.FromArgb(194, 224, 255); } }
    // ボタンがオンの場合に使用するグラデーションの中間色を取得します。
    public override Color ButtonSelectedGradientMiddle { get { return Color.FromArgb(194, 224, 255); } }
    // ボタンがオンの場合に使用する純色を取得します。
    public override Color ButtonSelectedHighlight { get { return Color.FromArgb(196, 225, 255); } }
    // ButtonSelectedHighlight で使用する境界線の色を取得します。
    public override Color ButtonSelectedHighlightBorder { get { return Color.FromArgb(51, 153, 255); } }
    // チェック ボタンがオンで、グラデーションが使用される場合に使用する純色を取得します。
    public override Color CheckBackground { get { return Color.FromArgb(196, 225, 255); } }
    // チェック ボタンがオンで、グラデーションが使用されるときに使用する純色を取得します。
    public override Color CheckPressedBackground { get { return Color.FromArgb(153, 204, 255); } }
    // チェック ボタンがオンで、グラデーションが使用される場合に使用する純色を取得します。
    public override Color CheckSelectedBackground { get { return Color.FromArgb(153, 204, 255); } }
    // グリップ (移動ハンドル) のシャドウ効果に使用する色を取得します。
    public override Color GripDark { get { return Color.FromArgb(255, 192, 192); } }
    // グリップ (移動ハンドル) の強調表示効果に使用する色を取得します。
    public override Color GripLight { get { return Color.FromArgb(255, 255, 255); } }
    // ToolStripDropDownMenu のイメージのマージンで使用するグラデーションの開始色を取得します。
    public override Color ImageMarginGradientBegin { get { return Color.FromArgb(27, 27, 28); } }
    // ToolStripDropDownMenu のイメージのマージンで使用するグラデーションの終了色を取得します。
    public override Color ImageMarginGradientEnd { get { return Color.FromArgb(27, 27, 28); } }
    // ToolStripDropDownMenu のイメージのマージンで使用するグラデーションの中間色を取得します。
    public override Color ImageMarginGradientMiddle { get { return Color.FromArgb(27, 27, 28); } }
    // ToolStripDropDownMenu に項目が表示される場合にイメージのマージンで使用するグラデーションの開始色を取得します。
    public override Color ImageMarginRevealedGradientBegin { get { return Color.FromArgb(249, 249, 249); } }
    // ToolStripDropDownMenu に項目が表示される場合にイメージのマージンで使用するグラデーションの終了色を取得します。
    public override Color ImageMarginRevealedGradientEnd { get { return Color.FromArgb(242, 242, 242); } }
    // ToolStripDropDownMenu で項目が表示される場合にイメージのマージンで使用するグラデーションの中間色を取得します。
    public override Color ImageMarginRevealedGradientMiddle { get { return Color.FromArgb(245, 245, 245); } }
    // MenuStrip の境界線の色を取得します。
    public override Color MenuBorder { get { return Color.FromArgb(51, 51, 55); } }
    // ToolStripMenuItem で使用する境界線の色を取得します。
    public override Color MenuItemBorder { get { return Color.FromArgb(62, 62, 64); } }
    // 最上位の ToolStripMenuItem が押されている場合に使用するグラデーションの開始色を取得します。
    public override Color MenuItemPressedGradientBegin { get { return Color.FromArgb(27, 27, 28); } }
    // 最上位の ToolStripMenuItem が押されている場合に使用するグラデーションの終了色を取得します。
    public override Color MenuItemPressedGradientEnd { get { return Color.FromArgb(27, 27, 28); } }
    // 最上位の ToolStripMenuItem が押されている場合に使用するグラデーションの中間色を取得します。
    public override Color MenuItemPressedGradientMiddle { get { return Color.FromArgb(27, 27, 28); } }
    // 最上位の ToolStripMenuItem 以外の ToolStripMenuItem が選択され場合に使用する純色を取得します。
    public override Color MenuItemSelected { get { return Color.FromArgb(51, 51, 52); } }
    // ToolStripMenuItem が選択された場合に使用するグラデーションの開始色を取得します。
    public override Color MenuItemSelectedGradientBegin { get { return Color.FromArgb(62, 62, 64); } }
    // ToolStripMenuItem が選択された場合に使用するグラデーションの終了色を取得します。
    public override Color MenuItemSelectedGradientEnd { get { return Color.FromArgb(62, 62, 64); } }
    // MenuStrip で使用するグラデーションの開始色を取得します。
    public override Color MenuStripGradientBegin { get { return Color.FromArgb(45, 45, 48); } }
    // MenuStrip で使用するグラデーションの終了色を取得します。
    public override Color MenuStripGradientEnd { get { return Color.FromArgb(45, 45, 48); } }
    // ToolStripOverflowButton で使用するグラデーションの開始色を取得します。
    public override Color OverflowButtonGradientBegin { get { return Color.FromArgb(245, 245, 245); } }
    // ToolStripOverflowButton で使用するグラデーションの終了色を取得します。
    public override Color OverflowButtonGradientEnd { get { return Color.FromArgb(160, 160, 160); } }
    // ToolStripOverflowButton で使用するグラデーションの中間色を取得します。
    public override Color OverflowButtonGradientMiddle { get { return Color.FromArgb(242, 242, 242); } }
    // ToolStripContainer で使用するグラデーションの開始色を取得します。
    public override Color RaftingContainerGradientBegin { get { return Color.FromArgb(240, 240, 240); } }
    // ToolStripContainer で使用するグラデーションの終了色を取得します。
    public override Color RaftingContainerGradientEnd { get { return Color.FromArgb(252, 252, 252); } }
    // ToolStripSeparator のシャドウ効果に使用する色を取得します。
    public override Color SeparatorDark { get { return Color.FromArgb(189, 189, 189); } }
    // ToolStripSeparator の強調表示効果に使用する色を取得します。
    public override Color SeparatorLight { get { return Color.FromArgb(255, 255, 255); } }
    // StatusStrip で使用するグラデーションの開始色を取得します。
    public override Color StatusStripGradientBegin { get { return Color.FromArgb(0, 122, 204); } }
    // StatusStrip で使用するグラデーションの終了色を取得します。
    public override Color StatusStripGradientEnd { get { return Color.FromArgb(0, 122, 204); } }
    // ToolStrip の下端に使用する境界線の色を取得します。
    public override Color ToolStripBorder { get { return Color.FromArgb(242, 242, 242); } }
    // ToolStripContentPanel で使用するグラデーションの開始色を取得します。
    public override Color ToolStripContentPanelGradientBegin { get { return Color.FromArgb(240, 240, 240); } }
    // ToolStripContentPanel で使用するグラデーションの終了色を取得します。
    public override Color ToolStripContentPanelGradientEnd { get { return Color.FromArgb(252, 252, 252); } }
    // ToolStripDropDown の純色の背景色を取得します。
    public override Color ToolStripDropDownBackground { get { return Color.FromArgb(27, 27, 28); } }
    // ToolStrip の背景で使用するグラデーションの開始色を取得します。
    public override Color ToolStripGradientBegin { get { return Color.FromArgb(45, 45, 48); } }
    // ToolStrip の背景で使用するグラデーションの終了色を取得します。
    public override Color ToolStripGradientEnd { get { return Color.FromArgb(45, 45, 48); } }
    // ToolStrip の背景で使用するグラデーションの中間色を取得します。
    public override Color ToolStripGradientMiddle { get { return Color.FromArgb(45, 45, 48); } }
    // ToolStripPanel で使用するグラデーションの開始色を取得します。
    public override Color ToolStripPanelGradientBegin { get { return Color.FromArgb(240, 240, 240); } }
    // ToolStripPanel で使用するグラデーションの終了色を取得します。
    public override Color ToolStripPanelGradientEnd { get { return Color.FromArgb(252, 252, 252); } }
}

