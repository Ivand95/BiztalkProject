namespace BizTalk_Server_Project1 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk_Server_Project1.Schema1", typeof(global::BizTalk_Server_Project1.Schema1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk_Server_Project1.Schema2", typeof(global::BizTalk_Server_Project1.Schema2))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BizTalk_Server_Project1.Schema1"" xmlns:ns0=""http://BizTalk_Server_Project1.Schema2"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Root>
      <FacturaId>
        <xsl:value-of select=""OrdenId/text()"" />
      </FacturaId>
      <FullName>
        <xsl:value-of select=""FullName/text()"" />
      </FullName>
      <TotalAmount>
        <xsl:value-of select=""TotalAmount/text()"" />
      </TotalAmount>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalk_Server_Project1.Schema1";
        
        private const global::BizTalk_Server_Project1.Schema1 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalk_Server_Project1.Schema2";
        
        private const global::BizTalk_Server_Project1.Schema2 _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BizTalk_Server_Project1.Schema1";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalk_Server_Project1.Schema2";
                return _TrgSchemas;
            }
        }
    }
}
