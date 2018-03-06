namespace BP1 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BP1.BP1_SourceSchema", typeof(global::BP1.BP1_SourceSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BP1.BP1_OutputSchema", typeof(global::BP1.BP1_OutputSchema))]
    public sealed class BP1_Map : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BP1.BP1_SourceSchema"" xmlns:ns0=""http://BP1.BP1_OutputSchema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Root>
      <Apellido>
        <xsl:value-of select=""Apellido/text()"" />
      </Apellido>
      <Nombre>
        <xsl:value-of select=""Nombre/text()"" />
      </Nombre>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BP1.BP1_SourceSchema";
        
        private const global::BP1.BP1_SourceSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BP1.BP1_OutputSchema";
        
        private const global::BP1.BP1_OutputSchema _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BP1.BP1_SourceSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BP1.BP1_OutputSchema";
                return _TrgSchemas;
            }
        }
    }
}
