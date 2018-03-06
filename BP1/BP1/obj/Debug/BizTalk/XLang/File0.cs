
#pragma warning disable 162

namespace BP1
{

    [System.SerializableAttribute]
    sealed public class __BP1_BP1_SourceSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BP1.BP1_SourceSchema _schema = new BP1.BP1_SourceSchema();

        public __BP1_BP1_SourceSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(BP1.BP1_SourceSchema)
        },
        new string[]{
            "MessagePart_1"
        },
        new System.Type[]{
            typeof(__BP1_BP1_SourceSchema__)
        },
        0,
        @"http://BP1.BP1_SourceSchema#Root"
    )]
    [System.SerializableAttribute]
    sealed internal class MultipartType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BP1_BP1_SourceSchema__ MessagePart_1;

        private void __CreatePartWrappers()
        {
            MessagePart_1 = new __BP1_BP1_SourceSchema__(this, "MessagePart_1", 0);
            this.AddPart("MessagePart_1", 0, MessagePart_1);
        }

        public MultipartType_1(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __BP1_BP1_OutputSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BP1.BP1_OutputSchema _schema = new BP1.BP1_OutputSchema();

        public __BP1_BP1_OutputSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(BP1.BP1_OutputSchema)
        },
        new string[]{
            "MessagePart_1"
        },
        new System.Type[]{
            typeof(__BP1_BP1_OutputSchema__)
        },
        0,
        @"http://BP1.BP1_OutputSchema#Root"
    )]
    [System.SerializableAttribute]
    sealed internal class MultipartType_2 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BP1_BP1_OutputSchema__ MessagePart_1;

        private void __CreatePartWrappers()
        {
            MessagePart_1 = new __BP1_BP1_OutputSchema__(this, "MessagePart_1", 0);
            this.AddPart("MessagePart_1", 0, MessagePart_1);
        }

        public MultipartType_2(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(BP1.MultipartType_1)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_1(PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_1 p = new PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_1),
            typeof(MultipartType_1),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(BP1.MultipartType_2)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_2 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_2(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_2(PortType_2 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_2 p = new PortType_2(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_2),
            typeof(MultipartType_2),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 222 "D:\Ivan\Desktop\Projects\BiztalkProject\BP1\BP1\BP1_Orchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceivePort", "Operation_1", 0, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ActivationPredicateAttribute(
        0,
        new bool[] {
            true,
            true
        },
        new System.Type[] {
            typeof(BTS.ReceivePortName),
            typeof(BTS.MessageType)
        },
        new Microsoft.XLANGs.BaseTypes.EXLangPredicateOperator[] {
            Microsoft.XLANGs.BaseTypes.EXLangPredicateOperator.eOpEqual,
            Microsoft.XLANGs.BaseTypes.EXLangPredicateOperator.eOpEqual
        },
        new System.Object[] {
            "ReceivePort1",
            "http://BP1.BP1_SourceSchema"
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(BP1.PortType_1),
            typeof(BP1.PortType_2)
        },
        new System.String[] {
            "ReceivePort",
            "SendPort"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class BP1_Orchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(BP1_Orchestration));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static BP1_Orchestration()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __BP1_Orchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public BP1_Orchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "BP1_Orchestration", tracker)
        {
            ConstructorHelper();
        }

        public BP1_Orchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "BP1_Orchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>42fa8bcd-1607-4448-8277-092f230e3893</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>e0a9cd23-c97c-4d7b-97cc-7688c3d27c03</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DNFPredicateShape</shapeType>      <ShapeID>d75094c5-ccd8-4952-8dcf-7a87fc729a6d</ShapeID>      <ParentLink>Receive_DNFPredicate</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DNFPredicateShape</shapeType>      <ShapeID>c3120682-caa6-448b-a65a-08dff27882f3</ShapeID>      <ParentLink>Receive_DNFPredicate</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>5326cc53-824b-4a6a-9704-14e01c0d16c2</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>67e71de1-6b27-41b1-8e0f-288e6316b2c5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>852ff572-fc84-4f51-9164-e05cfc1cb1c4</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>03fe5d3f-65a2-4ff3-afce-510a508d7edb</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>bfb8b767-d729-452f-9118-56dd83647c84</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>2320cafd-7738-4101-a938-b61073b69b04</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'BP1_Orchestration'</ActionName><IsAtomic>0</IsAtomic><Line>222</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>233</Line><Position>117</Position><ShapeID>'e0a9cd23-c97c-4d7b-97cc-7688c3d27c03'</ShapeID>
<Messages>
	<MsgInfo><name>Message_1</name><part>MessagePart_1</part><schema>BP1.BP1_SourceSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>235</Line><Position>13</Position><ShapeID>'5326cc53-824b-4a6a-9704-14e01c0d16c2'</ShapeID>
<Messages>
	<MsgInfo><name>Message_2</name><part>MessagePart_1</part><schema>BP1.BP1_OutputSchema</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Message_1</name><part>MessagePart_1</part><schema>BP1.BP1_SourceSchema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>241</Line><Position>13</Position><ShapeID>'2320cafd-7738-4101-a938-b61073b69b04'</ShapeID>
<Messages>
	<MsgInfo><name>Message_2</name><part>MessagePart_1</part><schema>BP1.BP1_OutputSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='5c56bb22-c1ac-4c7d-9f06-fa6b07b9a6ef' LowerBound='1.1' HigherBound='50.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='BP1' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='MultipartMessageType' OID='81dc2096-fe6b-44db-a2d1-5507104c6ad1' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MultipartType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='8933c43d-d732-4999-b0dc-bca7d59fdb17' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='BP1.BP1_SourceSchema' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='67eeff0d-2233-44c0-8f56-0a45bc8facdf' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MultipartType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='6899602f-f44f-4739-8375-80f03dcce22a' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='BP1.BP1_OutputSchema' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='d59c6270-2591-4887-a0a3-50028580ea09' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='c78a5aea-5d17-4a73-9229-3ac86532b79d' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='bd86d91d-d71e-46d4-a949-87f23599f59a' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.28'>
                    <om:Property Name='Ref' Value='BP1.MultipartType_1' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='950213f1-eca5-47af-b2a0-fe3f5e8d50a5' ParentLink='Module_PortType' LowerBound='19.1' HigherBound='26.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='09c11273-5f1f-4abf-9af1-fd19a690abda' ParentLink='PortType_OperationDeclaration' LowerBound='21.1' HigherBound='25.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='4e3fcea8-e58c-4bcd-b6dd-80eecf746349' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='23.13' HigherBound='23.28'>
                    <om:Property Name='Ref' Value='BP1.MultipartType_2' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='24c88f5d-035d-4732-8e24-63e080b4f3a0' ParentLink='Module_ServiceDeclaration' LowerBound='26.1' HigherBound='49.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='BP1_Orchestration' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='42fa8bcd-1607-4448-8277-092f230e3893' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='e0a9cd23-c97c-4d7b-97cc-7688c3d27c03' ParentLink='ServiceBody_Statement' LowerBound='37.1' HigherBound='39.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceivePort' />
                    <om:Property Name='MessageName' Value='Message_1' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DNFPredicate' OID='d75094c5-ccd8-4952-8dcf-7a87fc729a6d' ParentLink='Receive_DNFPredicate'>
                        <om:Property Name='LHS' Value='BTS.ReceivePortName' />
                        <om:Property Name='RHS' Value='&quot;ReceivePort1&quot;' />
                        <om:Property Name='Grouping' Value='OR' />
                        <om:Property Name='Operator' Value='Equals' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='DNFPredicate' OID='c3120682-caa6-448b-a65a-08dff27882f3' ParentLink='Receive_DNFPredicate'>
                        <om:Property Name='LHS' Value='BTS.MessageType' />
                        <om:Property Name='RHS' Value='&quot;http://BP1.BP1_SourceSchema&quot;' />
                        <om:Property Name='Grouping' Value='AND' />
                        <om:Property Name='Operator' Value='Equals' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Construct' OID='5326cc53-824b-4a6a-9704-14e01c0d16c2' ParentLink='ServiceBody_Statement' LowerBound='39.1' HigherBound='45.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='67e71de1-6b27-41b1-8e0f-288e6316b2c5' ParentLink='ComplexStatement_Statement' LowerBound='42.1' HigherBound='44.1'>
                        <om:Property Name='ClassName' Value='BP1.BP1_Map' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='852ff572-fc84-4f51-9164-e05cfc1cb1c4' ParentLink='Transform_InputMessagePartRef' LowerBound='43.68' HigherBound='43.91'>
                            <om:Property Name='MessageRef' Value='Message_1' />
                            <om:Property Name='PartRef' Value='MessagePart_1' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='03fe5d3f-65a2-4ff3-afce-510a508d7edb' ParentLink='Transform_OutputMessagePartRef' LowerBound='43.28' HigherBound='43.51'>
                            <om:Property Name='MessageRef' Value='Message_2' />
                            <om:Property Name='PartRef' Value='MessagePart_1' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='bfb8b767-d729-452f-9118-56dd83647c84' ParentLink='Construct_MessageRef' LowerBound='40.23' HigherBound='40.32'>
                        <om:Property Name='Ref' Value='Message_2' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='2320cafd-7738-4101-a938-b61073b69b04' ParentLink='ServiceBody_Statement' LowerBound='45.1' HigherBound='47.1'>
                    <om:Property Name='PortName' Value='SendPort' />
                    <om:Property Name='MessageName' Value='Message_2' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='3eef9bc4-1d3f-4eb0-adeb-1815e9afcfe3' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='29.1' HigherBound='31.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Unbound' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BP1.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceivePort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='bc62ab48-5503-4d14-a982-0d99d8d31abb' ParentLink='PortDeclaration_CLRAttribute' LowerBound='29.1' HigherBound='30.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='a1e158de-0416-4294-9af5-92ea5bac663e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='31.1' HigherBound='33.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='13' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BP1.PortType_2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='ee20c5f5-5784-4125-b1b7-3ce4b4d96346' ParentLink='PortDeclaration_CLRAttribute' LowerBound='31.1' HigherBound='32.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0083376d-796a-465b-8a40-e33bb8d062b6' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='33.1' HigherBound='34.1'>
                <om:Property Name='Type' Value='BP1.MultipartType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='e150e643-0593-44f0-b21a-3e1c68558335' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='BP1.MultipartType_2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message_2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __BP1_Orchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __BP1_Orchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BP1_Orchestration")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                BP1_Orchestration __svc__ = (BP1_Orchestration)_service;
                __BP1_Orchestration_root_0 __ctx0__ = (__BP1_Orchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SendPort != null)
                {
                    __svc__.SendPort.Close(this, null);
                    __svc__.SendPort = null;
                }
                if (__svc__.ReceivePort != null)
                {
                    __svc__.ReceivePort.Close(this, null);
                    __svc__.ReceivePort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __BP1_Orchestration_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __BP1_Orchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BP1_Orchestration")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                BP1_Orchestration __svc__ = (BP1_Orchestration)_service;
                __BP1_Orchestration_1 __ctx1__ = (__BP1_Orchestration_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Message_2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_2);
                    __ctx1__.__Message_2 = null;
                }
                if (__ctx1__ != null && __ctx1__.__Message_1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_1);
                    __ctx1__.__Message_1 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Message_1")]
            internal MultipartType_1 __Message_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Message_2")]
            internal MultipartType_2 __Message_2;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceivePort")]
        internal PortType_1 ReceivePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendPort")]
        internal PortType_2 SendPort;
        private static BTS.MessageType _prop_BTS_MessageType = new BTS.MessageType();
        private static BTS.ReceivePortName _prop_BTS_ReceivePortName = new BTS.ReceivePortName();

        sealed private class PredicateSet0_0 : Microsoft.XLANGs.Core.PredicateGroup
        {
            public PredicateSet0_0() : base(1)
            {
                Add(new Microsoft.XLANGs.Core.FullySpecifiedPredicate(_prop_BTS_ReceivePortName, Microsoft.XLANGs.Core.PredicateBase.Operators.eEqual, "ReceivePort1"));
            }
        }


        sealed private class PredicateSet0_1 : Microsoft.XLANGs.Core.PredicateGroup
        {
            public PredicateSet0_1() : base(1)
            {
                Add(new Microsoft.XLANGs.Core.FullySpecifiedPredicate(_prop_BTS_MessageType, Microsoft.XLANGs.Core.PredicateBase.Operators.eEqual, "http://BP1.BP1_SourceSchema"));
            }
        }


        private static Microsoft.XLANGs.Core.PredicateGroup[] _predicates0 = {
            new PredicateSet0_0(),
            new PredicateSet0_1()
        };


        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(BP1_Orchestration).GetField("ReceivePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BP1_Orchestration), "ReceivePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_2.Operation_1},
                                               typeof(BP1_Orchestration).GetField("SendPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BP1_Orchestration), "SendPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, _predicates0 , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "e0a9cd23-c97c-4d7b-97cc-7688c3d27c03", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "e0a9cd23-c97c-4d7b-97cc-7688c3d27c03", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "5326cc53-824b-4a6a-9704-14e01c0d16c2", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "5326cc53-824b-4a6a-9704-14e01c0d16c2", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "2320cafd-7738-4101-a938-b61073b69b04", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "2320cafd-7738-4101-a938-b61073b69b04", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,7,7,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,7,7,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __BP1_Orchestration_root_0 __ctx0__ = (__BP1_Orchestration_root_0)_stateMgrs[0];
            __BP1_Orchestration_1 __ctx1__ = (__BP1_Orchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ReceivePort = new PortType_1(0, this);
                SendPort = new PortType_2(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceivePort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __BP1_Orchestration_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __BP1_Orchestration_root_0 __ctx0__ = (__BP1_Orchestration_root_0)_stateMgrs[0];
            __BP1_Orchestration_1 __ctx1__ = (__BP1_Orchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!ReceivePort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Message_1 != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Message_1);
                __ctx1__.__Message_1 = new MultipartType_1("Message_1", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Message_1);
                ReceivePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__Message_1, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceivePort != null)
                {
                    ReceivePort.Close(__ctx1__, __seg__);
                    ReceivePort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Message_1);
                    __edata.PortName = @"ReceivePort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    MultipartType_2 __Message_2 = new MultipartType_2("Message_2", __ctx1__);

                    ApplyTransform(typeof(BP1.BP1_Map), new object[] {__Message_2.MessagePart_1}, new object[] {__ctx1__.__Message_1.MessagePart_1});

                    if (__ctx1__.__Message_2 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Message_2);
                    __ctx1__.__Message_2 = __Message_2;
                    __ctx1__.RefMessage(__ctx1__.__Message_2);
                }
                __ctx1__.__Message_2.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Message_2);
                    __edata.Messages.Add(__ctx1__.__Message_1);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Message_1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_1);
                    __ctx1__.__Message_1 = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendPort.SendMessage(0, __ctx1__.__Message_2, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendPort != null)
                {
                    SendPort.Close(__ctx1__, __seg__);
                    SendPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Message_2);
                    __edata.PortName = @"SendPort";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Message_2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_2);
                    __ctx1__.__Message_2 = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 15;
            case 15:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
