//=============================================================================

public static partial class _x_  // any extension methods
{
	public static libMBIN.NMS.LinkableNMSTemplate AsLinkable(
		this libMBIN.NMSTemplate TEMPLATE,
		     string              LINKED = ""
	){
		return new() {
			Template = TEMPLATE,
			Linked   = LINKED ?? ""
		};
	}

	//...........................................................
	// todo: need more scalable solution for conversions between
	//       NMSTemplate and LinkableNMSTemplate.
	//...........................................................
	
	public static NMSTEMPLATE_T FindFirst<NMSTEMPLATE_T>(
		this System.Collections.Generic.List<libMBIN.NMS.LinkableNMSTemplate> LIST,
		     string        LINKED  = null,
		     NMSTEMPLATE_T ON_NULL = default
	){
		if( LIST == null ) return ON_NULL;		
		foreach( var item in LIST ) {
			if( item.Template is NMSTEMPLATE_T nmstemplate_t ) {
				if( LINKED == null || string.Equals(item.Linked, LINKED, StringComparison.OrdinalIgnoreCase) ) {
					return nmstemplate_t;
				}
			}
		}		
		return ON_NULL;
	}
	
	//...........................................................

	public static void Add(
		this System.Collections.Generic.List<libMBIN.NMS.LinkableNMSTemplate> LIST,
		     libMBIN.NMSTemplate TEMPLATE,
		     string              LINKED = ""
	){
		var linkable = TEMPLATE?.AsLinkable(LINKED);
		if( linkable != null ) LIST?.Add(linkable);
	}

	//...........................................................

	public static void Remove(
		this System.Collections.Generic.List<libMBIN.NMS.LinkableNMSTemplate> LIST,
		     libMBIN.NMSTemplate TEMPLATE,
		     string              LINKED = null
	){
		if( LIST != null )
		for( var i = 0; i < LIST.Count; ++i ) {
			if( LIST[i].Template == TEMPLATE ) {
				if( LINKED == null || string.Equals(LIST[i].Linked, LINKED, StringComparison.OrdinalIgnoreCase) ) {
					LIST.RemoveAt(i);
					break;
				}
			}
		}
	}
}

//=============================================================================
