using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// Summary description for Tools
/// </summary>
public class Tools
{
	public Tools()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    /// <summary> 

    /// Finds a Control recursively. Note finds the first match that exists 

    /// </summary> 

    /// <param name="ContainerCtl">Should be the lowest container in the heirarchy, for eg dont choose Master page if you can pick the specific panel</param> 

    /// <param name="IdToFind">ID of the control you are looking for</param> 

    /// <returns>the control if found else null</returns> 

    public static Control FindControlRecursive(Control Root, string Id)
    {
        if (Root.ID == Id)

            return Root;

        foreach (Control Ctl in Root.Controls)
        {

            Control FoundCtl = FindControlRecursive(Ctl, Id);

            if (FoundCtl != null)

                return FoundCtl;
        }
        return null;
    }

    public static string CropText(string input, int MaxLength, bool DoDots)
    {
        string result = input;
        int InputLength = input.Length;

        string LastChar = result.Substring(result.Length - 1);

        if (MaxLength < InputLength)
        {
            result = input.Substring(0, MaxLength);

            if (LastChar == " ")
            {
                result = result.Substring(0, result.Length - 1);
            }

            if (DoDots)
            {
                result = "....";
            }
        }

        return result;
    }

}
