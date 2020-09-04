using System;


/// -----------------------------------------------------------------------------
/// <summary>
///     検証・エラーチェックをサポートした静的クラスです。
/// </summary>
/// -----------------------------------------------------------------------------

public sealed class Validation
{

    #region　IsNumeric メソッド (+1)

    /// -----------------------------------------------------------------------------
    /// <summary>
    ///     文字列が数値であるかどうかを返します。</summary>
    /// <param name="stTarget">
    ///     検査対象となる文字列。<param>
    /// <returns>
    ///     指定した文字列が数値であれば true。それ以外は false。</returns>
    /// -----------------------------------------------------------------------------
    public static bool IsNumeric(string stTarget)
    {
        double dNullable;

        return double.TryParse(
            stTarget,
            System.Globalization.NumberStyles.Any,
            null,
            out dNullable
        );
    }


    /// -----------------------------------------------------------------------------
    /// <summary>
    ///     オブジェクトが数値であるかどうかを返します。</summary>
    /// <param name="oTarget">
    ///     検査対象となるオブジェクト。<param>
    /// <returns>
    ///     指定したオブジェクトが数値であれば true。それ以外は false。</returns>
    /// -----------------------------------------------------------------------------
    public static bool IsNumeric(object oTarget)
    {
        return IsNumeric(oTarget.ToString());
    }

    #endregion

}
