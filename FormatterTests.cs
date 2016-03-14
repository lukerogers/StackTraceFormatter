using NUnit.Framework;

namespace Elmah
{
    public class FormatterTests
    {
        [Test]
        public void StackTraceKillsApplication()
        {
            var trace = StackTraceFormatter.FormatHtml(stack, null);

            //Will never get here
            Assert.True(trace != null);
        }

        private readonly string stack =
            @"NHibernate.Exceptions.GenericADOException: Failed to execute multi query[SQL: select codingques0_.Id as Id2_0_, choicename1_.TextID as TextID130_1_, choicename1_.LanguageID as LanguageID130_1_, codingques0_.VersionStamp as VersionS2_2_0_, codingques0_.CreatedBy as CreatedBy2_0_, codingques0_.CreatedDateTime as CreatedD4_2_0_, codingques0_.LastUpdateBy as LastUpda5_2_0_, codingques0_.LastUpdateDateTime as LastUpda6_2_0_, codingques0_.CodingQuestionID as CodingQu7_2_0_, codingques0_.TreeID as TreeID2_0_, codingques0_.CodingSpec as CodingSpec2_0_, codingques0_.ClassificationKeywordID as Classif10_2_0_, codingques0_.ChoiceTextLTID as ChoiceT11_2_0_, codingques0_.PositionIndex as Positio12_2_0_, codingques0_.CodingValue as CodingV13_2_0_, codingques0_.ChoiceNumber as ChoiceN14_2_0_, codingques0_.[TreeID].GetLevel() as formula1_0_, (select case when exists(select 1 from Survey.CodingQuestionChoice a where a.CodingQuestionID = codingques0_.CodingQuestionID and a.TreeID.GetAncestor(1) = codingques0_.TreeID) then 1 else 0 end) as formula2_0_, choicename1_.LocalizedText as Localize3_130_1_, choicename1_.TextID as TextID0__, choicename1_.LanguageID as LanguageID0__ from Survey.CodingQuestionChoice codingques0_ left outer join Administration.LocalizedTextSequenced choicename1_ on codingques0_.ChoiceTextLTID=choicename1_.TextID where codingques0_.CodingQuestionID=?;
select codingques0_.Id as Id2_0_, codingques1_.ID as ID3_1_, codingques0_.VersionStamp as VersionS2_2_0_, codingques0_.CreatedBy as CreatedBy2_0_, codingques0_.CreatedDateTime as CreatedD4_2_0_, codingques0_.LastUpdateBy as LastUpda5_2_0_, codingques0_.LastUpdateDateTime as LastUpda6_2_0_, codingques0_.CodingQuestionID as CodingQu7_2_0_, codingques0_.TreeID as TreeID2_0_, codingques0_.CodingSpec as CodingSpec2_0_, codingques0_.ClassificationKeywordID as Classif10_2_0_, codingques0_.ChoiceTextLTID as ChoiceT11_2_0_, codingques0_.PositionIndex as Positio12_2_0_, codingques0_.CodingValue as CodingV13_2_0_, codingques0_.ChoiceNumber as ChoiceN14_2_0_, codingques0_.[TreeID].GetLevel() as formula1_0_, (select case when exists(select 1 from Survey.CodingQuestionChoice a where a.CodingQuestionID = codingques0_.CodingQuestionID and a.TreeID.GetAncestor(1) = codingques0_.TreeID) then 1 else 0 end) as formula2_0_, codingques1_.VersionStamp as VersionS2_3_1_, codingques1_.CodingQuestionChoiceID as CodingQu3_3_1_, codingques1_.StringPath as StringPath3_1_, codingques1_.StartCodingValue as StartCod5_3_1_, codingques1_.EndCodingValue as EndCodin6_3_1_, codingques1_.CodingSpec as CodingSpec3_1_, codingques1_.CreatedBy as CreatedBy3_1_, codingques1_.CreatedDateTime as CreatedD9_3_1_, codingques1_.LastUpdateBy as LastUpd10_3_1_, codingques1_.LastUpdateDateTime as LastUpd11_3_1_, codingques1_.CodingQuestionChoiceID as CodingQu3_0__, codingques1_.ID as ID0__ from Survey.CodingQuestionChoice codingques0_ left outer join Survey.CodingQuestionChoiceCodingRange codingques1_ on codingques0_.Id=codingques1_.CodingQuestionChoiceID where codingques0_.CodingQuestionID=?;
] ---> System.IO.FileLoadException: Could not load file or assembly 'Microsoft.SqlServer.Types, Version=10.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91' or one of its dependencies. The located assembly's manifest definition does not match the assembly reference. (Exception from HRESULT: 0x80131040)
   at System.Reflection.RuntimeAssembly._nLoad(AssemblyName fileName, String codeBase, Evidence assemblySecurity, RuntimeAssembly locationHint, StackCrawlMark& stackMark, IntPtr pPrivHostBinder, Boolean throwOnFileNotFound, Boolean forIntrospection, Boolean suppressSecurityChecks)
   at System.Reflection.RuntimeAssembly.InternalLoadAssemblyName(AssemblyName assemblyRef, Evidence assemblySecurity, RuntimeAssembly reqAssembly, StackCrawlMark& stackMark, IntPtr pPrivHostBinder, Boolean throwOnFileNotFound, Boolean forIntrospection, Boolean suppressSecurityChecks)
   at System.Reflection.Assembly.Load(AssemblyName assemblyRef)
   at System.Data.SqlClient.SqlConnection.ResolveTypeAssembly(AssemblyName asmRef, Boolean throwOnError)
   at System.TypeNameParser.ResolveAssembly(String asmName, Func`2 assemblyResolver, Boolean throwOnError, StackCrawlMark& stackMark)
   at System.TypeNameParser.ConstructType(Func`2 assemblyResolver, Func`4 typeResolver, Boolean throwOnError, Boolean ignoreCase, StackCrawlMark& stackMark)
   at System.TypeNameParser.GetType(String typeName, Func`2 assemblyResolver, Func`4 typeResolver, Boolean throwOnError, Boolean ignoreCase, StackCrawlMark& stackMark)
   at System.Type.GetType(String typeName, Func`2 assemblyResolver, Func`4 typeResolver, Boolean throwOnError)
   at System.Data.SqlClient.SqlConnection.CheckGetExtendedUDTInfo(SqlMetaDataPriv metaData, Boolean fThrow)
   at System.Data.SqlClient.SqlDataReader.GetValueFromSqlBufferInternal(SqlBuffer data, _SqlMetaData metaData)
   at System.Data.SqlClient.SqlDataReader.GetValue(Int32 i)
   at NHibernate.Type.AbstractStringType.Get(IDataReader rs, Int32 index)
   at NHibernate.Type.NullableType.NullSafeGet(IDataReader rs, String name)
   at NHibernate.Persister.Entity.AbstractEntityPersister.Hydrate(IDataReader rs, Object id, Object obj, ILoadable rootLoadable, String[][] suffixedPropertyColumns, Boolean allProperties, ISessionImplementor session)
   at NHibernate.Loader.Loader.LoadFromResultSet(IDataReader rs, Int32 i, Object obj, String instanceClass, EntityKey key, String rowIdAlias, LockMode lockMode, ILoadable rootPersister, ISessionImplementor session)
   at NHibernate.Loader.Loader.InstanceNotYetLoaded(IDataReader dr, Int32 i, ILoadable persister, EntityKey key, LockMode lockMode, String rowIdAlias, EntityKey optionalObjectKey, Object optionalObject, IList hydratedObjects, ISessionImplementor session)
   at NHibernate.Loader.Loader.GetRow(IDataReader rs, ILoadable[] persisters, EntityKey[] keys, Object optionalObject, EntityKey optionalObjectKey, LockMode[] lockModes, IList hydratedObjects, ISessionImplementor session)
   at NHibernate.Loader.Loader.GetRowFromResultSet(IDataReader resultSet, ISessionImplementor session, QueryParameters queryParameters, LockMode[] lockModeArray, EntityKey optionalObjectKey, IList hydratedObjects, EntityKey[] keys, Boolean returnProxies, IResultTransformer forcedResultTransformer)
   at NHibernate.Impl.MultiQueryImpl.DoList()";
    }
}