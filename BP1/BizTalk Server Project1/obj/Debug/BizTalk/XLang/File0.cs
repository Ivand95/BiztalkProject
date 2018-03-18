
#pragma warning disable 162

namespace BizTalk_Server_Project1
{

    [System.SerializableAttribute]
    sealed public class __BizTalk_Server_Project1_Schema1__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BizTalk_Server_Project1.Schema1 _schema = new BizTalk_Server_Project1.Schema1();

        public __BizTalk_Server_Project1_Schema1__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(BizTalk_Server_Project1.Schema1)
        },
        new string[]{
            "MessagePart_1"
        },
        new System.Type[]{
            typeof(__BizTalk_Server_Project1_Schema1__)
        },
        0,
        @"http://BizTalk_Server_Project1.Schema1#Root"
    )]
    [System.SerializableAttribute]
    sealed internal class MultipartType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BizTalk_Server_Project1_Schema1__ MessagePart_1;

        private void __CreatePartWrappers()
        {
            MessagePart_1 = new __BizTalk_Server_Project1_Schema1__(this, "MessagePart_1", 0);
            this.AddPart("MessagePart_1", 0, MessagePart_1);
        }

        public MultipartType_1(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __BizTalk_Server_Project1_Schema2__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BizTalk_Server_Project1.Schema2 _schema = new BizTalk_Server_Project1.Schema2();

        public __BizTalk_Server_Project1_Schema2__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(BizTalk_Server_Project1.Schema2)
        },
        new string[]{
            "MessagePart_1"
        },
        new System.Type[]{
            typeof(__BizTalk_Server_Project1_Schema2__)
        },
        0,
        @"http://BizTalk_Server_Project1.Schema2#Root"
    )]
    [System.SerializableAttribute]
    sealed internal class MultipartType_2 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BizTalk_Server_Project1_Schema2__ MessagePart_1;

        private void __CreatePartWrappers()
        {
            MessagePart_1 = new __BizTalk_Server_Project1_Schema2__(this, "MessagePart_1", 0);
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
            typeof(BizTalk_Server_Project1.MultipartType_1)
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
            typeof(BizTalk_Server_Project1.MultipartType_2)
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(BizTalk_Server_Project1.MultipartType_2)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_3 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_3(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_3(PortType_3 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_3 p = new PortType_3(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_3),
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
    [Microsoft.XLANGs.BaseTypes.CorrelationTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        new string[] {
            "BizTalk_Server_Project1.FacturaId"
        }
    )]
    sealed internal class FacturaIdCorrType : Microsoft.XLANGs.Core.CorrelationType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        private static Microsoft.XLANGs.BaseTypes.PropertyBase[] _properties = new Microsoft.XLANGs.BaseTypes.PropertyBase[] {
            new BizTalk_Server_Project1.FacturaId()
         };
        public override Microsoft.XLANGs.BaseTypes.PropertyBase[] Properties { get { return _properties; } }
        public static Microsoft.XLANGs.BaseTypes.PropertyBase[] PropertiesList { get { return _properties; } }
    }
    //#line 320 "C:\Users\iserrata\Desktop\Projects\BiztalkProject\BP1\BizTalk Server Project1\BizTalk Orchestration1.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RecepcionOrden", "Operation_1", 0, -1, true
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
            "RecepcionOrden",
            "http://BizTalk_Server_Project1.Schema1"
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(BizTalk_Server_Project1.PortType_1),
            typeof(BizTalk_Server_Project1.PortType_3),
            typeof(BizTalk_Server_Project1.PortType_2)
        },
        new System.String[] {
            "RecepcionOrden",
            "RegistroFacturas",
            "EnvioFacturas"
        },
        new System.Type[] {
            null,
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
    sealed internal class BizTalk_Orchestration1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(BizTalk_Orchestration1));
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

        static BizTalk_Orchestration1()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 1, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 1, 3)
            };

            _Locks = 0;
            _rootContext = new __BizTalk_Orchestration1_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public BizTalk_Orchestration1(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "BizTalk_Orchestration1", tracker)
        {
            ConstructorHelper();
        }

        public BizTalk_Orchestration1(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "BizTalk_Orchestration1")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>7902d8fe-30b4-4937-b710-a5be1c8286db</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>f630850d-9952-4d40-922e-2d716999c8d8</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DNFPredicateShape</shapeType>      <ShapeID>19207569-e359-43d3-afae-da808bf6e623</ShapeID>      <ParentLink>Receive_DNFPredicate</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DNFPredicateShape</shapeType>      <ShapeID>23f9873c-7989-4641-827a-e2506e3d7802</ShapeID>      <ParentLink>Receive_DNFPredicate</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>4e23e07e-a834-42df-95b4-7ab862180425</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>94204231-59ab-41b7-a8eb-3e46fd84bf77</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>84422f24-d7f0-4d32-ae09-52e4479168c3</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1ab9db5e-a82a-4549-8059-6ce7c0cf61e2</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>6426800c-7722-49ff-8288-88aee4571f0f</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelShape</shapeType>      <ShapeID>7b976cbe-fc1a-4475-97e2-1b5ff1fd7afb</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ParallelActions_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>7c92b31c-1aa8-4dc0-830a-3b78cea2db85</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>2560ed40-82ee-4134-b9ee-00ac56b8a497</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>44277c56-d7af-4568-a3cd-ae7a007bbed5</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>3e9500b6-e1da-496e-bfb6-d8458f828ede</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'BizTalk_Orchestration1'</ActionName><IsAtomic>0</IsAtomic><Line>320</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>334</Line><Position>130</Position><ShapeID>'f630850d-9952-4d40-922e-2d716999c8d8'</ShapeID>
<Messages>
	<MsgInfo><name>Message_1</name><part>MessagePart_1</part><schema>BizTalk_Server_Project1.Schema1</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>336</Line><Position>13</Position><ShapeID>'4e23e07e-a834-42df-95b4-7ab862180425'</ShapeID>
<Messages>
	<MsgInfo><name>Message_2</name><part>MessagePart_1</part><schema>BizTalk_Server_Project1.Schema2</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Message_1</name><part>MessagePart_1</part><schema>BizTalk_Server_Project1.Schema1</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>342</Line><Position>13</Position><ShapeID>'7b976cbe-fc1a-4475-97e2-1b5ff1fd7afb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>347</Line><Position>21</Position><ShapeID>'2560ed40-82ee-4134-b9ee-00ac56b8a497'</ShapeID>
<Messages>
	<MsgInfo><name>Message_2</name><part>MessagePart_1</part><schema>BizTalk_Server_Project1.Schema2</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>352</Line><Position>21</Position><ShapeID>'3e9500b6-e1da-496e-bfb6-d8458f828ede'</ShapeID>
<Messages>
	<MsgInfo><name>Message_2</name><part>MessagePart_1</part><schema>BizTalk_Server_Project1.Schema2</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='90f9e102-a942-4fd1-a316-09737ce2d7a4' LowerBound='1.1' HigherBound='76.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='BizTalk_Server_Project1' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='ad6d0aee-21af-4ba8-b9cf-e3ff1bab30a9' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e88848fe-d7d5-4018-8e75-f21f25a729ca' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='1a813150-11ef-4a57-bf40-04447e96a0c5' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.28'>
                    <om:Property Name='Ref' Value='BizTalk_Server_Project1.MultipartType_1' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='086159d5-a65a-47ae-9298-ad26641179a8' ParentLink='Module_PortType' LowerBound='19.1' HigherBound='26.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e92d346b-ebf6-46c8-98c6-af94da98659d' ParentLink='PortType_OperationDeclaration' LowerBound='21.1' HigherBound='25.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='029807ee-cf7d-4334-9114-04900773d55c' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='23.13' HigherBound='23.28'>
                    <om:Property Name='Ref' Value='BizTalk_Server_Project1.MultipartType_2' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='c35edd6a-66ce-4c77-9ce4-208f81b06d8a' ParentLink='Module_PortType' LowerBound='26.1' HigherBound='33.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_3' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='95ac5188-0dfe-40c9-8d9e-5c372c0de38f' ParentLink='PortType_OperationDeclaration' LowerBound='28.1' HigherBound='32.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='f571e610-d5a2-437c-acbe-a23d6d1371b0' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='30.13' HigherBound='30.28'>
                    <om:Property Name='Ref' Value='BizTalk_Server_Project1.MultipartType_2' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='47d6a0ec-a571-46f0-ac90-8ae5af31c8af' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MultipartType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='700dba57-43fc-4535-8741-d30ea538e985' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='BizTalk_Server_Project1.Schema1' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='d1e629ee-0cc3-4d5b-bd07-90466fb89e4c' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='MultipartType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='b7963e2f-41a8-4045-b8c5-98fb72748d1f' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='BizTalk_Server_Project1.Schema2' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='29d6ca34-b217-48f8-81b4-994d7641d75d' ParentLink='Module_ServiceDeclaration' LowerBound='37.1' HigherBound='75.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='BizTalk_Orchestration1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='e488bff0-55d1-40ca-ab32-8e534884e05f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='47.1' HigherBound='48.1'>
                <om:Property Name='Type' Value='BizTalk_Server_Project1.MultipartType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='b73d88a4-9af1-4207-bbb2-7ac73ab5e11c' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='Type' Value='BizTalk_Server_Project1.MultipartType_2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message_2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='7902d8fe-30b4-4937-b710-a5be1c8286db' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='f630850d-9952-4d40-922e-2d716999c8d8' ParentLink='ServiceBody_Statement' LowerBound='51.1' HigherBound='53.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RecepcionOrden' />
                    <om:Property Name='MessageName' Value='Message_1' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DNFPredicate' OID='19207569-e359-43d3-afae-da808bf6e623' ParentLink='Receive_DNFPredicate'>
                        <om:Property Name='LHS' Value='BTS.ReceivePortName' />
                        <om:Property Name='RHS' Value='&quot;RecepcionOrden&quot;' />
                        <om:Property Name='Grouping' Value='OR' />
                        <om:Property Name='Operator' Value='Equals' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='DNFPredicate' OID='23f9873c-7989-4641-827a-e2506e3d7802' ParentLink='Receive_DNFPredicate'>
                        <om:Property Name='LHS' Value='BTS.MessageType' />
                        <om:Property Name='RHS' Value='&quot;http://BizTalk_Server_Project1.Schema1&quot;' />
                        <om:Property Name='Grouping' Value='AND' />
                        <om:Property Name='Operator' Value='Equals' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Construct' OID='4e23e07e-a834-42df-95b4-7ab862180425' ParentLink='ServiceBody_Statement' LowerBound='53.1' HigherBound='59.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='94204231-59ab-41b7-a8eb-3e46fd84bf77' ParentLink='ComplexStatement_Statement' LowerBound='56.1' HigherBound='58.1'>
                        <om:Property Name='ClassName' Value='BizTalk_Server_Project1.Map1' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='84422f24-d7f0-4d32-ae09-52e4479168c3' ParentLink='Transform_InputMessagePartRef' LowerBound='57.85' HigherBound='57.108'>
                            <om:Property Name='MessageRef' Value='Message_1' />
                            <om:Property Name='PartRef' Value='MessagePart_1' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='1ab9db5e-a82a-4549-8059-6ce7c0cf61e2' ParentLink='Transform_OutputMessagePartRef' LowerBound='57.28' HigherBound='57.51'>
                            <om:Property Name='MessageRef' Value='Message_2' />
                            <om:Property Name='PartRef' Value='MessagePart_1' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='6426800c-7722-49ff-8288-88aee4571f0f' ParentLink='Construct_MessageRef' LowerBound='54.23' HigherBound='54.32'>
                        <om:Property Name='Ref' Value='Message_2' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Parallel' OID='7b976cbe-fc1a-4475-97e2-1b5ff1fd7afb' ParentLink='ServiceBody_Statement' LowerBound='59.1' HigherBound='73.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ParallelActions_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='ParallelBranch' OID='7c92b31c-1aa8-4dc0-830a-3b78cea2db85' ParentLink='ReallyComplexStatement_Branch' LowerBound='64.1' HigherBound='66.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Send' OID='2560ed40-82ee-4134-b9ee-00ac56b8a497' ParentLink='ComplexStatement_Statement' LowerBound='64.1' HigherBound='66.1'>
                            <om:Property Name='PortName' Value='RegistroFacturas' />
                            <om:Property Name='MessageName' Value='Message_2' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='ParallelBranch' OID='44277c56-d7af-4568-a3cd-ae7a007bbed5' ParentLink='ReallyComplexStatement_Branch' LowerBound='69.1' HigherBound='71.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_2' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Send' OID='3e9500b6-e1da-496e-bfb6-d8458f828ede' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='71.1'>
                            <om:Property Name='PortName' Value='EnvioFacturas' />
                            <om:Property Name='MessageName' Value='Message_2' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='112f4b31-17a7-48fe-a3f9-33f927cca84c' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='40.1' HigherBound='42.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Unbound' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BizTalk_Server_Project1.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RecepcionOrden' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='bee18e13-9dbb-4b8e-8436-c236ef148e95' ParentLink='PortDeclaration_CLRAttribute' LowerBound='40.1' HigherBound='41.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='3813f82f-83e2-4577-a629-6b0180c30f0d' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='42.1' HigherBound='44.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='18' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BizTalk_Server_Project1.PortType_3' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RegistroFacturas' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='90a9fdb8-5690-4d89-8cad-8a368fb77569' ParentLink='PortDeclaration_CLRAttribute' LowerBound='42.1' HigherBound='43.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='cda65a44-d6e3-4466-adaa-3b54d178adfc' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='44.1' HigherBound='46.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='21' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BizTalk_Server_Project1.PortType_2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EnvioFacturas' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='648e732f-1dec-4187-a2da-24a36ee69d75' ParentLink='PortDeclaration_CLRAttribute' LowerBound='44.1' HigherBound='45.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='CorrelationDeclaration' OID='d5420c86-afff-4578-b584-d7237c5af600' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='Type' Value='BizTalk_Server_Project1.FacturaIdCorrType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FacturaIdCorrSet' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='80cac11f-bdcd-496c-9b88-012ac42fe21e' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='70.65' HigherBound='70.92'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='3e9500b6-e1da-496e-bfb6-d8458f828ede' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='d638e13e-9d62-4749-8400-e317f98f49bc' ParentLink='Module_CorrelationType' LowerBound='33.1' HigherBound='37.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='FacturaIdCorrType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PropertyRef' OID='3d2e2ecd-a73b-460e-976b-5c4a614fed97' ParentLink='CorrelationType_PropertyRef' LowerBound='35.9' HigherBound='35.18'>
                <om:Property Name='Ref' Value='BizTalk_Server_Project1.FacturaId' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __BizTalk_Orchestration1_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __BizTalk_Orchestration1_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BizTalk_Orchestration1")
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
                BizTalk_Orchestration1 __svc__ = (BizTalk_Orchestration1)_service;
                __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.RecepcionOrden != null)
                {
                    __svc__.RecepcionOrden.Close(this, null);
                    __svc__.RecepcionOrden = null;
                }
                if (__svc__.RegistroFacturas != null)
                {
                    __svc__.RegistroFacturas.Close(this, null);
                    __svc__.RegistroFacturas = null;
                }
                if (__svc__.EnvioFacturas != null)
                {
                    __svc__.EnvioFacturas.Close(this, null);
                    __svc__.EnvioFacturas = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __BizTalk_Orchestration1_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __BizTalk_Orchestration1_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BizTalk_Orchestration1")
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
                BizTalk_Orchestration1 __svc__ = (BizTalk_Orchestration1)_service;
                __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__FacturaIdCorrSet != null)
                    __ctx1__.__FacturaIdCorrSet = null;
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
            [Microsoft.XLANGs.Core.UserVariableAttribute("FacturaIdCorrSet")]
            internal Microsoft.XLANGs.Core.Correlation __FacturaIdCorrSet;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = new Microsoft.XLANGs.Core.CorrelationType[] { new FacturaIdCorrType() };
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("RecepcionOrden")]
        internal PortType_1 RecepcionOrden;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RegistroFacturas")]
        internal PortType_3 RegistroFacturas;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("EnvioFacturas")]
        internal PortType_2 EnvioFacturas;
        private static BTS.MessageType _prop_BTS_MessageType = new BTS.MessageType();
        private static BTS.ReceivePortName _prop_BTS_ReceivePortName = new BTS.ReceivePortName();

        sealed private class PredicateSet0_0 : Microsoft.XLANGs.Core.PredicateGroup
        {
            public PredicateSet0_0() : base(1)
            {
                Add(new Microsoft.XLANGs.Core.FullySpecifiedPredicate(_prop_BTS_ReceivePortName, Microsoft.XLANGs.Core.PredicateBase.Operators.eEqual, "RecepcionOrden"));
            }
        }


        sealed private class PredicateSet0_1 : Microsoft.XLANGs.Core.PredicateGroup
        {
            public PredicateSet0_1() : base(1)
            {
                Add(new Microsoft.XLANGs.Core.FullySpecifiedPredicate(_prop_BTS_MessageType, Microsoft.XLANGs.Core.PredicateBase.Operators.eEqual, "http://BizTalk_Server_Project1.Schema1"));
            }
        }


        private static Microsoft.XLANGs.Core.PredicateGroup[] _predicates0 = {
            new PredicateSet0_0(),
            new PredicateSet0_1()
        };


        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("RecepcionOrden", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "RecepcionOrden"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_3.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("RegistroFacturas", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "RegistroFacturas"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_2.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("EnvioFacturas", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "EnvioFacturas"),
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
                h[_portInfo[2].Name] = _portInfo[2];
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "f630850d-9952-4d40-922e-2d716999c8d8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "f630850d-9952-4d40-922e-2d716999c8d8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "4e23e07e-a834-42df-95b4-7ab862180425", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "4e23e07e-a834-42df-95b4-7ab862180425", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "7b976cbe-fc1a-4475-97e2-1b5ff1fd7afb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "7b976cbe-fc1a-4475-97e2-1b5ff1fd7afb", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "2560ed40-82ee-4134-b9ee-00ac56b8a497", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "2560ed40-82ee-4134-b9ee-00ac56b8a497", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "3e9500b6-e1da-496e-bfb6-d8458f828ede", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "3e9500b6-e1da-496e-bfb6-d8458f828ede", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,11,11,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,6,6,11,11,11,11,};
        public static int[] __progressLocation2 = new int[] { 7,7,7,8,6,};
        public static int[] __progressLocation3 = new int[] { 9,9,9,10,6,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                RecepcionOrden = new PortType_1(0, this);
                RegistroFacturas = new PortType_3(1, this);
                EnvioFacturas = new PortType_2(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RecepcionOrden, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __BizTalk_Orchestration1_1(this);
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
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];

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
                if (!RecepcionOrden.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Message_1 != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Message_1);
                __ctx1__.__Message_1 = new MultipartType_1("Message_1", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Message_1);
                RecepcionOrden.ReceiveMessage(0, __msgEnv__, __ctx1__.__Message_1, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RecepcionOrden != null)
                {
                    RecepcionOrden.Close(__ctx1__, __seg__);
                    RecepcionOrden = null;
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
                    __edata.PortName = @"RecepcionOrden";
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

                    ApplyTransform(typeof(BizTalk_Server_Project1.Map1), new object[] {__Message_2.MessagePart_1}, new object[] {__ctx1__.__Message_1.MessagePart_1});

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
                __seg__.RunSegments(new Microsoft.XLANGs.Core.Segment[] {_segments[2], _segments[3]}, this);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__Message_2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_2);
                    __ctx1__.__Message_2 = null;
                }
                if (EnvioFacturas != null)
                {
                    EnvioFacturas.Close(__ctx1__, __seg__);
                    EnvioFacturas = null;
                }
                if (RegistroFacturas != null)
                {
                    RegistroFacturas.Close(__ctx1__, __seg__);
                    RegistroFacturas = null;
                }
                Tracker.FireEvent(__eventLocations[6],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 14;
            case 14:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RegistroFacturas.SendMessage(0, __ctx1__.__Message_2, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Message_2);
                    __edata.PortName = @"RegistroFacturas";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[4],_stateMgrs[1].TrackDataStream );
                __ctx1__.__FacturaIdCorrSet = new Microsoft.XLANGs.Core.Correlation(this, 0, 0);
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                EnvioFacturas.SendMessage(0, __ctx1__.__Message_2, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__FacturaIdCorrSet }, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (__ctx1__ != null && __ctx1__.__FacturaIdCorrSet != null)
                    __ctx1__.__FacturaIdCorrSet = null;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Message_2);
                    __edata.PortName = @"EnvioFacturas";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
