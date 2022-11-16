using System.Windows;

namespace AdventOfCode2015.Days
{
    internal class Day07
    {
        const string input = "lf AND lq -> ls\r\niu RSHIFT 1 -> jn\r\nbo OR bu -> bv\r\ngj RSHIFT 1 -> hc\r\net RSHIFT 2 -> eu\r\nbv AND bx -> by\r\nis OR it -> iu\r\nb OR n -> o\r\ngf OR ge -> gg\r\nNOT kt -> ku\r\nea AND eb -> ed\r\nkl OR kr -> ks\r\nhi AND hk -> hl\r\nau AND av -> ax\r\nlf RSHIFT 2 -> lg\r\ndd RSHIFT 3 -> df\r\neu AND fa -> fc\r\ndf AND dg -> di\r\nip LSHIFT 15 -> it\r\nNOT el -> em\r\net OR fe -> ff\r\nfj LSHIFT 15 -> fn\r\nt OR s -> u\r\nly OR lz -> ma\r\nko AND kq -> kr\r\nNOT fx -> fy\r\net RSHIFT 1 -> fm\r\neu OR fa -> fb\r\ndd RSHIFT 2 -> de\r\nNOT go -> gp\r\nkb AND kd -> ke\r\nhg OR hh -> hi\r\njm LSHIFT 1 -> kg\r\nNOT cn -> co\r\njp RSHIFT 2 -> jq\r\njp RSHIFT 5 -> js\r\n1 AND io -> ip\r\neo LSHIFT 15 -> es\r\n1 AND jj -> jk\r\ng AND i -> j\r\nci RSHIFT 3 -> ck\r\ngn AND gp -> gq\r\nfs AND fu -> fv\r\nlj AND ll -> lm\r\njk LSHIFT 15 -> jo\r\niu RSHIFT 3 -> iw\r\nNOT ii -> ij\r\n1 AND cc -> cd\r\nbn RSHIFT 3 -> bp\r\nNOT gw -> gx\r\nNOT ft -> fu\r\njn OR jo -> jp\r\niv OR jb -> jc\r\nhv OR hu -> hw\r\n19138 -> b\r\ngj RSHIFT 5 -> gm\r\nhq AND hs -> ht\r\ndy RSHIFT 1 -> er\r\nao OR an -> ap\r\nld OR le -> lf\r\nbk LSHIFT 1 -> ce\r\nbz AND cb -> cc\r\nbi LSHIFT 15 -> bm\r\nil AND in -> io\r\naf AND ah -> ai\r\nas RSHIFT 1 -> bl\r\nlf RSHIFT 3 -> lh\r\ner OR es -> et\r\nNOT ax -> ay\r\nci RSHIFT 1 -> db\r\net AND fe -> fg\r\nlg OR lm -> ln\r\nk AND m -> n\r\nhz RSHIFT 2 -> ia\r\nkh LSHIFT 1 -> lb\r\nNOT ey -> ez\r\nNOT di -> dj\r\ndz OR ef -> eg\r\nlx -> a\r\nNOT iz -> ja\r\ngz LSHIFT 15 -> hd\r\nce OR cd -> cf\r\nfq AND fr -> ft\r\nat AND az -> bb\r\nha OR gz -> hb\r\nfp AND fv -> fx\r\nNOT gb -> gc\r\nia AND ig -> ii\r\ngl OR gm -> gn\r\n0 -> c\r\nNOT ca -> cb\r\nbn RSHIFT 1 -> cg\r\nc LSHIFT 1 -> t\r\niw OR ix -> iy\r\nkg OR kf -> kh\r\ndy OR ej -> ek\r\nkm AND kn -> kp\r\nNOT fc -> fd\r\nhz RSHIFT 3 -> ib\r\nNOT dq -> dr\r\nNOT fg -> fh\r\ndy RSHIFT 2 -> dz\r\nkk RSHIFT 2 -> kl\r\n1 AND fi -> fj\r\nNOT hr -> hs\r\njp RSHIFT 1 -> ki\r\nbl OR bm -> bn\r\n1 AND gy -> gz\r\ngr AND gt -> gu\r\ndb OR dc -> dd\r\nde OR dk -> dl\r\nas RSHIFT 5 -> av\r\nlf RSHIFT 5 -> li\r\nhm AND ho -> hp\r\ncg OR ch -> ci\r\ngj AND gu -> gw\r\nge LSHIFT 15 -> gi\r\ne OR f -> g\r\nfp OR fv -> fw\r\nfb AND fd -> fe\r\ncd LSHIFT 15 -> ch\r\nb RSHIFT 1 -> v\r\nat OR az -> ba\r\nbn RSHIFT 2 -> bo\r\nlh AND li -> lk\r\ndl AND dn -> do\r\neg AND ei -> ej\r\nex AND ez -> fa\r\nNOT kp -> kq\r\nNOT lk -> ll\r\nx AND ai -> ak\r\njp OR ka -> kb\r\nNOT jd -> je\r\niy AND ja -> jb\r\njp RSHIFT 3 -> jr\r\nfo OR fz -> ga\r\ndf OR dg -> dh\r\ngj RSHIFT 2 -> gk\r\ngj OR gu -> gv\r\nNOT jh -> ji\r\nap LSHIFT 1 -> bj\r\nNOT ls -> lt\r\nir LSHIFT 1 -> jl\r\nbn AND by -> ca\r\nlv LSHIFT 15 -> lz\r\nba AND bc -> bd\r\ncy LSHIFT 15 -> dc\r\nln AND lp -> lq\r\nx RSHIFT 1 -> aq\r\ngk OR gq -> gr\r\nNOT kx -> ky\r\njg AND ji -> jj\r\nbn OR by -> bz\r\nfl LSHIFT 1 -> gf\r\nbp OR bq -> br\r\nhe OR hp -> hq\r\net RSHIFT 5 -> ew\r\niu RSHIFT 2 -> iv\r\ngl AND gm -> go\r\nx OR ai -> aj\r\nhc OR hd -> he\r\nlg AND lm -> lo\r\nlh OR li -> lj\r\nda LSHIFT 1 -> du\r\nfo RSHIFT 2 -> fp\r\ngk AND gq -> gs\r\nbj OR bi -> bk\r\nlf OR lq -> lr\r\ncj AND cp -> cr\r\nhu LSHIFT 15 -> hy\r\n1 AND bh -> bi\r\nfo RSHIFT 3 -> fq\r\nNOT lo -> lp\r\nhw LSHIFT 1 -> iq\r\ndd RSHIFT 1 -> dw\r\ndt LSHIFT 15 -> dx\r\ndy AND ej -> el\r\nan LSHIFT 15 -> ar\r\naq OR ar -> as\r\n1 AND r -> s\r\nfw AND fy -> fz\r\nNOT im -> in\r\net RSHIFT 3 -> ev\r\n1 AND ds -> dt\r\nec AND ee -> ef\r\nNOT ak -> al\r\njl OR jk -> jm\r\n1 AND en -> eo\r\nlb OR la -> lc\r\niu AND jf -> jh\r\niu RSHIFT 5 -> ix\r\nbo AND bu -> bw\r\ncz OR cy -> da\r\niv AND jb -> jd\r\niw AND ix -> iz\r\nlf RSHIFT 1 -> ly\r\niu OR jf -> jg\r\nNOT dm -> dn\r\nlw OR lv -> lx\r\ngg LSHIFT 1 -> ha\r\nlr AND lt -> lu\r\nfm OR fn -> fo\r\nhe RSHIFT 3 -> hg\r\naj AND al -> am\r\n1 AND kz -> la\r\ndy RSHIFT 5 -> eb\r\njc AND je -> jf\r\ncm AND co -> cp\r\ngv AND gx -> gy\r\nev OR ew -> ex\r\njp AND ka -> kc\r\nfk OR fj -> fl\r\ndy RSHIFT 3 -> ea\r\nNOT bs -> bt\r\nNOT ag -> ah\r\ndz AND ef -> eh\r\ncf LSHIFT 1 -> cz\r\nNOT cv -> cw\r\n1 AND cx -> cy\r\nde AND dk -> dm\r\nck AND cl -> cn\r\nx RSHIFT 5 -> aa\r\ndv LSHIFT 1 -> ep\r\nhe RSHIFT 2 -> hf\r\nNOT bw -> bx\r\nck OR cl -> cm\r\nbp AND bq -> bs\r\nas OR bd -> be\r\nhe AND hp -> hr\r\nev AND ew -> ey\r\n1 AND lu -> lv\r\nkk RSHIFT 3 -> km\r\nb AND n -> p\r\nNOT kc -> kd\r\nlc LSHIFT 1 -> lw\r\nkm OR kn -> ko\r\nid AND if -> ig\r\nih AND ij -> ik\r\njr AND js -> ju\r\nci RSHIFT 5 -> cl\r\nhz RSHIFT 1 -> is\r\n1 AND ke -> kf\r\nNOT gs -> gt\r\naw AND ay -> az\r\nx RSHIFT 2 -> y\r\nab AND ad -> ae\r\nff AND fh -> fi\r\nci AND ct -> cv\r\neq LSHIFT 1 -> fk\r\ngj RSHIFT 3 -> gl\r\nu LSHIFT 1 -> ao\r\nNOT bb -> bc\r\nNOT hj -> hk\r\nkw AND ky -> kz\r\nas AND bd -> bf\r\ndw OR dx -> dy\r\nbr AND bt -> bu\r\nkk AND kv -> kx\r\nep OR eo -> eq\r\nhe RSHIFT 1 -> hx\r\nki OR kj -> kk\r\nNOT ju -> jv\r\nek AND em -> en\r\nkk RSHIFT 5 -> kn\r\nNOT eh -> ei\r\nhx OR hy -> hz\r\nea OR eb -> ec\r\ns LSHIFT 15 -> w\r\nfo RSHIFT 1 -> gh\r\nkk OR kv -> kw\r\nbn RSHIFT 5 -> bq\r\nNOT ed -> ee\r\n1 AND ht -> hu\r\ncu AND cw -> cx\r\nb RSHIFT 5 -> f\r\nkl AND kr -> kt\r\niq OR ip -> ir\r\nci RSHIFT 2 -> cj\r\ncj OR cp -> cq\r\no AND q -> r\r\ndd RSHIFT 5 -> dg\r\nb RSHIFT 2 -> d\r\nks AND ku -> kv\r\nb RSHIFT 3 -> e\r\nd OR j -> k\r\nNOT p -> q\r\nNOT cr -> cs\r\ndu OR dt -> dv\r\nkf LSHIFT 15 -> kj\r\nNOT ac -> ad\r\nfo RSHIFT 5 -> fr\r\nhz OR ik -> il\r\njx AND jz -> ka\r\ngh OR gi -> gj\r\nkk RSHIFT 1 -> ld\r\nhz RSHIFT 5 -> ic\r\nas RSHIFT 2 -> at\r\nNOT jy -> jz\r\n1 AND am -> an\r\nci OR ct -> cu\r\nhg AND hh -> hj\r\njq OR jw -> jx\r\nv OR w -> x\r\nla LSHIFT 15 -> le\r\ndh AND dj -> dk\r\ndp AND dr -> ds\r\njq AND jw -> jy\r\nau OR av -> aw\r\nNOT bf -> bg\r\nz OR aa -> ab\r\nga AND gc -> gd\r\nhz AND ik -> im\r\njt AND jv -> jw\r\nz AND aa -> ac\r\njr OR js -> jt\r\nhb LSHIFT 1 -> hv\r\nhf OR hl -> hm\r\nib OR ic -> id\r\nfq OR fr -> fs\r\ncq AND cs -> ct\r\nia OR ig -> ih\r\ndd OR do -> dp\r\nd AND j -> l\r\nib AND ic -> ie\r\nas RSHIFT 3 -> au\r\nbe AND bg -> bh\r\ndd AND do -> dq\r\nNOT l -> m\r\n1 AND gd -> ge\r\ny AND ae -> ag\r\nfo AND fz -> gb\r\nNOT ie -> if\r\ne AND f -> h\r\nx RSHIFT 3 -> z\r\ny OR ae -> af\r\nhf AND hl -> hn\r\nNOT h -> i\r\nNOT hn -> ho\r\nhe RSHIFT 5 -> hh";

        Dictionary<string, UInt16> result = new Dictionary<string, ushort>();

        public Day07()
        {
            var result = Stage2();

            Console.WriteLine(result);

            Clipboard.SetText(result);
        }

        private string Stage1()
        {
            var commands = input.Split("\r\n");

            Dictionary<string, string> values = new Dictionary<string, string>();

            foreach (var command in commands)
            {
                var commandparts = command.Split(" -> ");

                values.Add(commandparts[1], commandparts[0]);
            }

            return GetValue(values, "a").ToString();
        }

        public UInt16 GetValue(Dictionary<string, string> values, string key)
        {
            if (result.ContainsKey(key))
            {
                return result[key];
            }

            var value = values[key];
            UInt16 leftValue = 0;
            UInt16 rightValue = 0;

            Console.WriteLine(value);

            if (value.Contains("AND"))
            {
                var parts = value.Split(" AND ");

                if (!UInt16.TryParse(parts[0], out leftValue))
                {
                    leftValue = GetValue(values, parts[0]);
                }

                if (!UInt16.TryParse(parts[1], out rightValue))
                {
                    rightValue = GetValue(values, parts[1]);
                }

                result.Add(key, (UInt16)(leftValue & rightValue));
                return (UInt16)(leftValue & rightValue);
            }

            if (value.Contains("OR"))
            {
                var parts = value.Split(" OR ");

                if (!UInt16.TryParse(parts[0], out leftValue))
                {
                    leftValue = GetValue(values, parts[0]);
                }

                if (!UInt16.TryParse(parts[1], out rightValue))
                {
                    rightValue = GetValue(values, parts[1]);
                }

                result.Add(key, (UInt16)(leftValue | rightValue));
                return (UInt16)(leftValue | rightValue);
            }

            if (value.Contains("RSHIFT"))
            {
                var parts = value.Split(" RSHIFT ");

                if (!UInt16.TryParse(parts[0], out leftValue))
                {
                    leftValue = GetValue(values, parts[0]);
                }

                if (!UInt16.TryParse(parts[1], out rightValue))
                {
                    rightValue = GetValue(values, parts[1]);
                }

                result.Add(key, (UInt16)(leftValue >> rightValue));
                return (UInt16)(leftValue >> rightValue);
            }

            if (value.Contains("LSHIFT"))
            {
                var parts = value.Split(" LSHIFT ");

                if (!UInt16.TryParse(parts[0], out leftValue))
                {
                    leftValue = GetValue(values, parts[0]);
                }

                if (!UInt16.TryParse(parts[1], out rightValue))
                {
                    rightValue = GetValue(values, parts[1]);
                }

                result.Add(key, (UInt16)(leftValue << rightValue));
                return (UInt16)(leftValue << rightValue);
            }

            if (value.Contains("NOT"))
            {
                var parts = value.Split("NOT ");

                if (!UInt16.TryParse(parts[1], out leftValue))
                {
                    leftValue = GetValue(values, parts[1]);
                }

                result.Add(key, (UInt16)~leftValue);
                return (UInt16)~leftValue;
            }

            if (!UInt16.TryParse(value, out leftValue))
            {
                leftValue = GetValue(values, value);
            }

            result.Add(key, leftValue);
            return leftValue;
        }

        private string Stage2()
        {
            var commands = input.Split("\r\n");

            Dictionary<string, string> values = new Dictionary<string, string>();

            foreach (var command in commands)
            {
                var commandparts = command.Split(" -> ");

                values.Add(commandparts[1], commandparts[0]);
            }

            values["b"] = "16076";

            return GetValue(values, "a").ToString();
        }
    }
}
