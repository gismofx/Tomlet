﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tomlet.Tests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TestResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tomlet.Tests.TestResources", typeof(TestResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to integers3 = [
        ///  1,
        ///  2, # this is ok
        ///].
        /// </summary>
        internal static string ArrayWithTrailingCommaTestInput {
            get {
                return ResourceManager.GetString("ArrayWithTrailingCommaTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # fractional
        ///flt1 = +1.0
        ///flt2 = 3.1415
        ///flt3 = -0.01
        ///
        ///# exponent
        ///flt4 = 5e+22
        ///flt5 = 1e06
        ///flt6 = -2E-2
        ///
        ///# both
        ///flt7 = 6.626e-34.
        /// </summary>
        internal static string BasicFloatTestInput {
            get {
                return ResourceManager.GetString("BasicFloatTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to name = { first = &quot;Tom&quot;, last = &quot;Preston-Werner&quot; }
        ///point = { x = 1, y = 2 }
        ///animal = { type.name = &quot;pug&quot; }.
        /// </summary>
        internal static string BasicInlineTableTestInput {
            get {
                return ResourceManager.GetString("BasicInlineTableTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to int1 = +99
        ///int2 = 42
        ///int3 = 0
        ///int4 = -17.
        /// </summary>
        internal static string BasicIntegerTestInput {
            get {
                return ResourceManager.GetString("BasicIntegerTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to key = &quot;value&quot;.
        /// </summary>
        internal static string BasicKVPTestInput {
            get {
                return ResourceManager.GetString("BasicKVPTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [table-1]
        ///key1 = &quot;some string&quot;
        ///key2 = 123
        ///
        ///[table-2]
        ///key1 = &quot;another string&quot;
        ///key2 = 456.
        /// </summary>
        internal static string BasicTableTestInput {
            get {
                return ResourceManager.GetString("BasicTableTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;&quot; = &quot;blank&quot;     # VALID but discouraged.
        /// </summary>
        internal static string BlankKeysAreAcceptedTestInput {
            get {
                return ResourceManager.GetString("BlankKeysAreAcceptedTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to bool1 = true
        ///bool2 = false.
        /// </summary>
        internal static string BooleanTestInput {
            get {
                return ResourceManager.GetString("BooleanTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # This is a full-line comment
        ///key = &quot;value&quot;  # This is a comment at the end of a line
        ///another = &quot;# This is not a comment&quot;.
        /// </summary>
        internal static string CommentTestInput {
            get {
                return ResourceManager.GetString("CommentTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [[fruits]]
        ///name = &quot;apple&quot;
        ///
        ///[fruits.physical]  # subtable
        ///color = &quot;red&quot;
        ///shape = &quot;round&quot;
        ///
        ///[[fruits.varieties]]  # nested array of tables
        ///name = &quot;red delicious&quot;
        ///
        ///[[fruits.varieties]]
        ///name = &quot;granny smith&quot;
        ///
        ///
        ///[[fruits]]
        ///name = &quot;banana&quot;
        ///
        ///[[fruits.varieties]]
        ///name = &quot;plantain&quot;.
        /// </summary>
        internal static string ComplexTableArrayTestInput {
            get {
                return ResourceManager.GetString("ComplexTableArrayTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [fruit.physical]  # subtable, but to which parent element should it belong?
        ///color = &quot;red&quot;
        ///shape = &quot;round&quot;
        ///
        ///[[fruit]]  # parser must throw an error upon discovering that &quot;fruit&quot; is
        ///           # an array rather than a table
        ///name = &quot;apple&quot;.
        /// </summary>
        internal static string DefiningAsArrayWhenAlreadyTableTestInput {
            get {
                return ResourceManager.GetString("DefiningAsArrayWhenAlreadyTableTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to site.&quot;google.com&quot;.allowed = true
        ///site.&quot;google.com&quot;.name = &quot;Google&quot;
        ///site.&quot;youtube.com&quot; = false.
        /// </summary>
        internal static string DottedKeysCanHaveQuotedSubkeysTestInput {
            get {
                return ResourceManager.GetString("DottedKeysCanHaveQuotedSubkeysTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fruit.name = &quot;banana&quot;     # this is best practice
        ///fruit. color = &quot;yellow&quot;    # same as fruit.color
        ///fruit . flavor = &quot;banana&quot;   # same as fruit.flavor.
        /// </summary>
        internal static string DottedKeyWhitespaceTestInput {
            get {
                return ResourceManager.GetString("DottedKeyWhitespaceTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to str4 = &quot;&quot;&quot;Here are two quotation marks: &quot;&quot;. Simple enough.&quot;&quot;&quot;
        ///str5 = &quot;&quot;&quot;Here are three quotation marks: &quot;&quot;\&quot;.&quot;&quot;&quot;
        ///str6 = &quot;&quot;&quot;Here are fifteen quotation marks: &quot;&quot;\&quot;&quot;&quot;\&quot;&quot;&quot;\&quot;&quot;&quot;\&quot;&quot;&quot;\&quot;.&quot;&quot;&quot;
        ///
        ///# &quot;This,&quot; she said, &quot;is just a pointless statement.&quot;
        ///str7 = &quot;&quot;&quot;&quot;This,&quot; she said, &quot;is just a pointless statement.&quot;&quot;&quot;&quot;.
        /// </summary>
        internal static string DoubleQuotesInMultilineBasicTestInput {
            get {
                return ResourceManager.GetString("DoubleQuotesInMultilineBasicTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to = &quot;no key name&quot;  # INVALID.
        /// </summary>
        internal static string EmptyKeyNameTestInput {
            get {
                return ResourceManager.GetString("EmptyKeyNameTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to str = &quot;I&apos;m a string. \&quot;You can quote me\&quot;. Name\tJos\u00E9\nLocation\tSF.&quot;.
        /// </summary>
        internal static string EscapedDoubleQuotedStringTestInput {
            get {
                return ResourceManager.GetString("EscapedDoubleQuotedStringTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # infinity
        ///sf1 = inf  # positive infinity
        ///sf2 = +inf # positive infinity
        ///sf3 = -inf # negative infinity
        ///
        ///# not a number
        ///sf4 = nan  # actual sNaN/qNaN encoding is implementation-specific
        ///sf5 = +nan # same as `nan`
        ///sf6 = -nan # valid, actual encoding is implementation-specific.
        /// </summary>
        internal static string FloatSpecialsTestInput {
            get {
                return ResourceManager.GetString("FloatSpecialsTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to flt8 = 224_617.445_991_228.
        /// </summary>
        internal static string FloatWithUnderscoresTestInput {
            get {
                return ResourceManager.GetString("FloatWithUnderscoresTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to type = { name = &quot;Nail&quot; }
        ///type.edible = false  # INVALID.
        /// </summary>
        internal static string InlineTableLockedTestInput {
            get {
                return ResourceManager.GetString("InlineTableLockedTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [fruit]
        ///apple = &quot;red&quot;
        ///
        ///[fruit.apple]
        ///texture = &quot;smooth&quot;.
        /// </summary>
        internal static string KeyRedefinitionViaTableTestInput {
            get {
                return ResourceManager.GetString("KeyRedefinitionViaTableTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to winpath  = &apos;C:\Users\nodejs\templates&apos;
        ///winpath2 = &apos;\\ServerX\admin$\system32\&apos;
        ///quoted   = &apos;Tom &quot;Dubs&quot; Preston-Werner&apos;
        ///regex    = &apos;&lt;\i\c*\s*&gt;&apos;
        ///empty = &apos;&apos;.
        /// </summary>
        internal static string LiteralStringTestInput {
            get {
                return ResourceManager.GetString("LiteralStringTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ld1 = 1979-05-27.
        /// </summary>
        internal static string LocalDateTestInput {
            get {
                return ResourceManager.GetString("LocalDateTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ldt1 = 1979-05-27T07:32:00
        ///ldt2 = 1979-05-27T00:32:00.999999.
        /// </summary>
        internal static string LocalDateTimeTestInput {
            get {
                return ResourceManager.GetString("LocalDateTimeTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to lt1 = 07:32:00
        ///lt2 = 00:32:00.999999.
        /// </summary>
        internal static string LocalTimeTestInput {
            get {
                return ResourceManager.GetString("LocalTimeTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to regex2 = &apos;&apos;&apos;I [dw]on&apos;t need \d{2} apples&apos;&apos;&apos;
        ///lines  = &apos;&apos;&apos;
        ///The first newline is
        ///trimmed in raw strings.
        ///   All other whitespace
        ///   is preserved.
        ///&apos;&apos;&apos;.
        /// </summary>
        internal static string MultiLineLiteralStringTestInput {
            get {
                return ResourceManager.GetString("MultiLineLiteralStringTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to str1 = &quot;&quot;&quot;
        ///Roses are red
        ///Violets are blue&quot;&quot;&quot;.
        /// </summary>
        internal static string MultiLineSimpleStringTestInput {
            get {
                return ResourceManager.GetString("MultiLineSimpleStringTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to first = &quot;Tom&quot; last = &quot;Preston-Werner&quot; # INVALID.
        /// </summary>
        internal static string MultiplePairsOnOneLineTestInput {
            get {
                return ResourceManager.GetString("MultiplePairsOnOneLineTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to nested_arrays_of_ints = [ [ 1, 2 ], [3, 4, 5] ]
        ///nested_mixed_array = [ [ 1, 2 ], [&quot;a&quot;, &quot;b&quot;, &quot;c&quot;] ].
        /// </summary>
        internal static string NestedArraysTestInput {
            get {
                return ResourceManager.GetString("NestedArraysTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to key = &quot;value&quot;
        ///bare_key = &quot;value&quot;
        ///bare-key = &quot;value&quot;
        ///1234 = &quot;value&quot;.
        /// </summary>
        internal static string NonSimpleKeysTestInput {
            get {
                return ResourceManager.GetString("NonSimpleKeysTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to odt1 = 1979-05-27T07:32:00Z
        ///odt2 = 1979-05-27T00:32:00-07:00
        ///odt3 = 1979-05-27T00:32:00.999999-07:00
        ///odt4 = 1979-05-27 07:32:00Z.
        /// </summary>
        internal static string OffsetDateTimeTestInput {
            get {
                return ResourceManager.GetString("OffsetDateTimeTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to integers = [ 1, 2, 3 ]
        ///colors = [ &quot;red&quot;, &quot;yellow&quot;, &quot;green&quot; ]
        ///string_array = [ &quot;all&quot;, &apos;strings&apos;, &quot;&quot;&quot;are the same&quot;&quot;&quot;, &apos;&apos;&apos;type&apos;&apos;&apos; ].
        /// </summary>
        internal static string PrimitiveArraysTestInput {
            get {
                return ResourceManager.GetString("PrimitiveArraysTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;127.0.0.1&quot; = &quot;value&quot;
        ///&quot;character encoding&quot; = &quot;value&quot;
        ///&quot;ʎǝʞ&quot; = &quot;value&quot;
        ///&apos;key2&apos; = &quot;value&quot;
        ///&apos;quoted &quot;value&quot;&apos; = &quot;value&quot;.
        /// </summary>
        internal static string QuotedKeysTestInput {
            get {
                return ResourceManager.GetString("QuotedKeysTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # INVALID TOML DOC
        ///fruits = []
        ///
        ///[[fruits]] # Not allowed.
        /// </summary>
        internal static string ReDefiningAnArrayAsATableArrayIsAnErrorTestInput {
            get {
                return ResourceManager.GetString("ReDefiningAnArrayAsATableArrayIsAnErrorTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # INVALID TOML DOC
        ///[[fruits]]
        ///name = &quot;apple&quot;
        ///
        ///[[fruits.varieties]]
        ///name = &quot;red delicious&quot;
        ///
        ///# INVALID: This table conflicts with the previous array of tables
        ///[fruits.varieties]
        ///name = &quot;granny smith&quot;
        ///
        ///[fruits.physical]
        ///color = &quot;red&quot;
        ///shape = &quot;round&quot;
        ///
        ///# INVALID: This array of tables conflicts with the previous table
        ///[[fruits.physical]]
        ///color = &quot;green&quot;.
        /// </summary>
        internal static string ReDefiningSubTableAsSubTableArrayTestInput {
            get {
                return ResourceManager.GetString("ReDefiningSubTableAsSubTableArrayTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to name = &quot;Orange&quot;
        ///physical.color = &quot;orange&quot;
        ///physical.shape = &quot;round&quot;.
        /// </summary>
        internal static string SimpleDottedKeyTestInput {
            get {
                return ResourceManager.GetString("SimpleDottedKeyTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MyString = &quot;Hello, world!&quot;
        ///MyFloat = 690.42 # I&apos;m a child.
        ///MyBool = true
        ///MyDateTime = 1970-01-01T07:00:00.
        /// </summary>
        internal static string SimplePrimitiveDeserializationTestInput {
            get {
                return ResourceManager.GetString("SimplePrimitiveDeserializationTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [[products]]
        ///name = &quot;Hammer&quot;
        ///sku = 738594937
        ///
        ///[[products]]  # empty table within the array
        ///
        ///[[products]]
        ///name = &quot;Nail&quot;
        ///sku = 284758393
        ///
        ///color = &quot;gray&quot;.
        /// </summary>
        internal static string SimpleTableArrayTestInput {
            get {
                return ResourceManager.GetString("SimpleTableArrayTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to quot15 = &apos;&apos;&apos;Here are fifteen quotation marks: &quot;&quot;&quot;&quot;&quot;&quot;&quot;&quot;&quot;&quot;&quot;&quot;&quot;&quot;&quot;&apos;&apos;&apos;
        ///
        ///# apos15 = &apos;&apos;&apos;Here are fifteen apostrophes: &apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;  # INVALID
        ///apos15 = &quot;Here are fifteen apostrophes: &apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&apos;&quot;
        ///
        ///# &apos;That,&apos; she said, &apos;is still pointless.&apos;
        ///str = &apos;&apos;&apos;&apos;That,&apos; she said, &apos;is still pointless.&apos;&apos;&apos;&apos;.
        /// </summary>
        internal static string SingleQuotesInMultilineLiteralTestInput {
            get {
                return ResourceManager.GetString("SingleQuotesInMultilineLiteralTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [fruit]
        ///apple = &quot;red&quot;
        ///
        ///[fruit]
        ///orange = &quot;orange&quot;.
        /// </summary>
        internal static string TableRedefinitionTestInput {
            get {
                return ResourceManager.GetString("TableRedefinitionTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [dog.&quot;tater.man&quot;]
        ///type.name = &quot;pug&quot;.
        /// </summary>
        internal static string TableWithQuotedDottedStringTestInput {
            get {
                return ResourceManager.GetString("TableWithQuotedDottedStringTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to int5 = 1_000
        ///int6 = 5_349_221
        ///int7 = 53_49_221  # Indian number system grouping
        ///int8 = 1_2_3_4_5  # VALID but discouraged.
        /// </summary>
        internal static string UnderscoresInIntegersTestInput {
            get {
                return ResourceManager.GetString("UnderscoresInIntegersTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to key = # INVALID .
        /// </summary>
        internal static string UnspecifiedValueTestInput {
            get {
                return ResourceManager.GetString("UnspecifiedValueTestInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to str1 = &quot;The quick brown fox jumps over the lazy dog.&quot;
        ///
        ///str2 = &quot;&quot;&quot;
        ///The quick brown \
        ///
        ///
        ///  fox jumps over \
        ///    the lazy dog.&quot;&quot;&quot;
        ///
        ///str3 = &quot;&quot;&quot;\
        ///       The quick brown \
        ///       fox jumps over \
        ///       the lazy dog.\
        ///       &quot;&quot;&quot;.
        /// </summary>
        internal static string WhitespaceRemovalTestInput {
            get {
                return ResourceManager.GetString("WhitespaceRemovalTestInput", resourceCulture);
            }
        }
    }
}
