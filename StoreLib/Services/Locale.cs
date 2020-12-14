﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace StoreLib.Services
{
    public class Locale
    {
        public Market Market { get; private set; }
        public Lang Language { get; private set; }
        public string MarketAsString { get; private set; }
        public string LanguageAsString { get; private set; }
        public string DCatTrail { get; private set; }

        public Locale(Market market, Lang lang, bool IncludeNeutral)
        {
            this.Market = market;
            this.Language = lang;
            this.MarketAsString = market.ToString();
            this.LanguageAsString = lang.ToString();
            if (IncludeNeutral) { this.DCatTrail = $"market={MarketAsString}&languages={LanguageAsString}-{MarketAsString},{LanguageAsString},neutral"; }
            else { this.DCatTrail = $"market={MarketAsString}&languages={LanguageAsString}-{MarketAsString},{LanguageAsString}"; }
        }

        public Locale(CultureInfo culture, bool IncludeNeutral)
        {
            string[] parts = culture.Name.Split('-');
            Enum.TryParse(culture.TwoLetterISOLanguageName, out Lang lang);
            Enum.TryParse(parts[1], out Market market);

            this.Market = market;
            this.Language = lang;
            this.MarketAsString = market.ToString();
            this.LanguageAsString = lang.ToString();
            if (IncludeNeutral) { this.DCatTrail = $"market={MarketAsString}&languages={culture.Name},{LanguageAsString},neutral"; }
            else { this.DCatTrail = $"market={MarketAsString}&languages={culture.Name},{LanguageAsString}"; }
        }
    }

    public enum Market
    {
        US,
        DZ,
        AR,
        AU,
        AT,
        BH,
        BD,
        BE,
        BR,
        BG,
        CA,
        CL,
        CN,
        CO,
        CR,
        HR,
        CY,
        CZ,
        DK,
        EG,
        EE,
        FI,
        FR,
        DE,
        GR,
        GT,
        HK,
        HU,
        IS,
        IN,
        ID,
        IQ,
        IE,
        IL,
        IT,
        JP,
        JO,
        KZ,
        KE,
        KW,
        LV,
        LB,
        LI,
        LT,
        LU,
        MY,
        MT,
        MR,
        MX,
        MA,
        NL,
        NZ,
        NG,
        NO,
        OM,
        PK,
        PE,
        PH,
        PL,
        PT,
        QA,
        RO,
        RU,
        SA,
        RS,
        SG,
        SK,
        SI,
        ZA,
        KR,
        ES,
        SE,
        CH,
        TW,
        TH,
        TT,
        TN,
        TR,
        UA,
        AE,
        GB,
        VN,
        YE,
        LY,
        LK,
        UY,
        VE,
        AF,
        AX,
        AL,
        AS,
        AO,
        AI,
        AQ,
        AG,
        AM,
        AW,
        BO,
        BQ,
        BA,
        BW,
        BV,
        IO,
        BN,
        BF,
        BI,
        KH,
        CM,
        CV,
        KY,
        CF,
        TD,
        TL,
        DJ,
        DM,
        DO,
        EC,
        SV,
        GQ,
        ER,
        ET,
        FK,
        FO,
        FJ,
        GF,
        PF,
        TF,
        GA,
        GM,
        GE,
        GH,
        GI,
        GL,
        GD,
        GP,
        GU,
        GG,
        GN,
        GW,
        GY,
        HT,
        HM,
        HN,
        AZ,
        BS,
        BB,
        BY,
        BZ,
        BJ,
        BM,
        BT,
        KM,
        CG,
        CD,
        CK,
        CX,
        CC,
        CI,
        CW,
        JM,
        SJ,
        JE,
        KI,
        KG,
        LA,
        LS,
        LR,
        MO,
        MK,
        MG,
        MW,
        IM,
        MH,
        MQ,
        MU,
        YT,
        FM,
        MD,
        MN,
        MS,
        MZ,
        MM,
        NA,
        NR,
        NP,
        MV,
        ML,
        NC,
        NI,
        NE,
        NU,
        NF,
        PW,
        PS,
        PA,
        PG,
        PY,
        RE,
        RW,
        BL,
        MF,
        WS,
        ST,
        SN,
        MP,
        PN,
        SX,
        SB,
        SO,
        SC,
        SL,
        GS,
        SH,
        KN,
        LC,
        PM,
        VC,
        TJ,
        TZ,
        TG,
        TK,
        TO,
        TM,
        TC,
        TV,
        UM,
        UG,
        VI,
        VG,
        WF,
        EH,
        ZM,
        ZW,
        UZ,
        VU,
        SR,
        SZ,
        AD,
        MC,
        SM,
        ME,
        VA
    }

    public enum Lang
    {
        iv,
        aa,
        af,
        agq,
        ak,
        am,
        ar,
        arn,
        asa,
        ast,
        az,
        ba,
        bas,
        be,
        bem,
        bez,
        bg,
        bin,
        bm,
        bn,
        bo,
        br,
        brx,
        bs,
        byn,
        ca,
        ce,
        cgg,
        chr,
        co,
        cs,
        cu,
        cy,
        da,
        dav,
        de,
        dje,
        dsb,
        dua,
        dv,
        dyo,
        dz,
        ebu,
        ee,
        el,
        en,
        eo,
        es,
        et,
        eu,
        ewo,
        fa,
        ff,
        fi,
        fil,
        fo,
        fr,
        fur,
        fy,
        ga,
        gd,
        gl,
        gn,
        gsw,
        gu,
        guz,
        gv,
        ha,
        haw,
        he,
        hi,
        hr,
        hsb,
        hu,
        hy,
        ia,
        ibb,
        id,
        ig,
        ii,
        it,
        iu,
        ja,
        jgo,
        jmc,
        jv,
        ka,
        kab,
        kam,
        kde,
        kea,
        khq,
        ki,
        kk,
        kkj,
        kl,
        kln,
        km,
        kn,
        ko,
        kok,
        kr,
        ks,
        ksb,
        ksf,
        ksh,
        ku,
        kw,
        ky,
        la,
        lag,
        lb,
        lg,
        lkt,
        ln,
        lo,
        lrc,
        lt,
        lu,
        luo,
        luy,
        lv,
        mas,
        mer,
        mfe,
        mg,
        mgh,
        mgo,
        mi,
        mk,
        ml,
        mn,
        mni,
        moh,
        mr,
        ms,
        mt,
        mua,
        my,
        mzn,
        naq,
        nb,
        nd,
        ne,
        nl,
        nmg,
        nn,
        nnh,
        nqo,
        nr,
        nso,
        nus,
        nyn,
        oc,
        om,
        or,
        os,
        pa,
        pap,
        pl,
        prg,
        prs,
        ps,
        pt,
        quc,
        quz,
        rm,
        rn,
        ro,
        rof,
        ru,
        rw,
        rwk,
        sa,
        sah,
        saq,
        sbp,
        sd,
        se,
        seh,
        ses,
        sg,
        shi,
        si,
        sk,
        sl,
        sma,
        smj,
        smn,
        sms,
        sn,
        so,
        sq,
        sr,
        ss,
        ssy,
        st,
        sv,
        sw,
        syr,
        ta,
        te,
        teo,
        tg,
        th,
        ti,
        tig,
        tk,
        tn,
        to,
        tr,
        ts,
        tt,
        twq,
        tzm,
        ug,
        uk,
        ur,
        uz,
        vai,
        ve,
        vi,
        vo,
        vun,
        wae,
        wal,
        wo,
        xh,
        xog,
        yav,
        yi,
        yo,
        zgh,
        zh,
        zu
    }
    
}
