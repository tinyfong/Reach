var awe = function () {
    function ha(a, b, c) {
        function h(a) { d.inArray(a, g) + 1 || (g.push(a), (a = d("#" + a).data("o")) && a.data && d.each(a.data.vals, function (a, b) { d.inArray(b, f) + 1 && e.push(b); h(b) })) } var f = a.data.vals, e = [], g = []; 1 < a.data.vals.length && d.each(f, function (a, b) { d.inArray(b, e) + 1 || h(b) }); d.each(f, function (h, g) {
            var l = d("#" + g).data("o"); d.inArray(g, e) + 1 || (d("#" + g).bind("aweready", b), l && l.pch ? d("#" + g).bind("awepch", function (c, h) {
                if (h) {
                    var e = h.p; d.grep(f, function (a) { return d.inArray(a, e) + 1 }).length ? b(h) : a.v.trigger("awepch",
                    h)
                }
            }) : c || d("#" + g).bind(q, function () { b({ p: [g] }) }))
        })
    } function W(a, b) { var c = 0; d.each(a.data.vals, function (a, b) { d("#" + b).data("notr") && c++ }); 0 == c && b() } function X(a, b) { a.pch = 1; a.v.change(function (b, d) { d = !d ? { p: [] } : d; d.p.push(a.i); a.v.trigger("awepch", d) }); W(a, b); ha(a, function (c) { W(a, function () { b(c) }) }) } function I(a) {
        var b = a.p, c = b.d; b.i && d("#" + b.i).length && d("#" + b.i).data("api").destroy(); b.g && (d(".awe-popup[aweg=" + b.g + "]").each(function () { d(this).data("api") && d(this).data("api").destroy() }), c.attr("aweg",
        b.g)); c.addClass("awe-popup"); b.i && c.attr("id", b.i); awe.popup(a)
    } function J(a) { a.find(".awe-searchtxt").on("keydown", function (a) { 13 == a.which && (p(a), d(this).change().data("aweval", d(this).val())) }) } function ia(a, b) { if (a.sc) a.fm.on("change", Y, function () { d(this).val() != d(this).data("aweval") && b() }); else a.fm.on("click", ".awe-searchbtn", b) } function P(a, b) { var c = function () { }; a.v.data("api", c); c.load = function (c) { c && (c.params && (a.params = c.params), c.oparams && (a.oparams = c.oparams)); return b() }; return c } function Z(a,
    b, c) { ua(a, b); var d; a.df && (d = a.df(b), -1 != d && c(d)); if (!a.df || -1 == d) return a.d.before(z), u(a, { url: a.url, data: b, success: c }, function () { var b = a.d.prev(); b.hasClass("awe-loading") && b.remove() }) } function Q(a, b, c) { a.v.trigger("aweload", [b, c]) } function ua(a, b) { a.v.trigger("awebeginload", [b]) } function v(a, b) { a.v.trigger(q, b); R(a.v) } function R(a) { a.valid && 0 < a.closest("form").length && a.valid() } function $(a, b) {
        var c; if (a.hasClass("awe-array")) { if (c = a.val()) try { c = d.parseJSON(c) } catch (h) { } else c = 0; c = c ? c : [] } else c =
        [a.val()]; return aa(c, b)
    } function qa(a) { var b = [], c; for (c in a) d.isArray(a[c]) ? b = b.concat(aa(a[c], c)) : b.push({ name: c, value: a[c] }); return b } function aa(a, b) { var c = []; d.isArray(a) || (a = [a]); for (var h = 0; h < a.length; h++) c.push({ name: b, value: a[h] }); return c } function Ba(a) { a.data && (a.data = { keys: a.data.split("|")[0].split(";"), vals: a.data.split("|")[1].split(";") }); a.pars && (a.pars = { keys: a.pars.split("|")[0].split(";"), vals: a.pars.split("|")[1].split(";") }); return a } function x(a, b) {
        var c = []; a.v && !b && (c = c.concat($(a.v,
        "v"))); a.oparams && (c = c.concat(qa(a.oparams))); a.oparams = 0; a.params && (c = c.concat(qa(a.params))); a.data && d.each(a.data.keys, function (b, f) { c = c.concat($(d("#" + a.data.vals[b]), f)) }); a.pars && d.each(a.pars.keys, function (b, d) { c = c.concat(aa(a.pars.vals[b], d)) }); a.parf && (c = c.concat(qa(a.parf()))); return c
    } function p(a) { a && a.preventDefault ? a.preventDefault() : a.returnValue = !1 } function D(a) { a.v = d("#" + a.i); a.f = a.v.parent(); a.d = a.f.find(".awe-display"); a.v.data("o", a) } function S(a) { return a.outerHeight(!0) - a.height() }
    function Ca(a, b) { a ? b.append('<tr class="awe-loadcont"><td>' + z + "</td></tr>") : b.append('<li class="awe-loadcont">' + z + "</li>") } function E(a, b, c, d) { c || (c = 1); var f = x(a, a), f = f.concat(b); a.srl.empty(); Ca(a.tl, a.srl); b = [{ name: "page", value: c }]; if (a.tl) var e = a.srl.closest("table").find("thead:first").html() ? !1 : !0, b = b.concat({ name: "isTheadEmpty", value: e }); b = f.concat(b); d && ua(a, b); return A(a, a.searchUrl, b, function (b) { var e = awe.readd(b, a); a.srl.empty(); Da(a, e, f, c); d && Q(a, b, e) }) } function Ea(a, b, c) {
        if (null != b) {
            void 0 !=
            b.Thead && c.closest("table").find("thead:first").html(b.Thead); var h = c.find(".awe-li").map(function () { return d(this).data("val") }); void 0 != b.Content ? (b = d("<div/>").append(b.Content), b.find(".awe-li").each(function () { 0 <= d.inArray(d(this).data("val"), h) && d(this).remove() }), c.append(b.children())) : d.each(b.Items, function (b, e) {
                var g = a.mode ? l : "<button type='button' class='awe-movebtn awe-btn'><i class='awe-icon'></i></button>"; 0 > d.inArray(e.K, h) && c.append("<li class='awe-li' data-val='" + e.K + "'>" + g + e.C +
                " </li>")
            }); a.dg && c.find(".awe-li").draggable({ cancel: "button", revert: "invalid", helper: "clone", cursor: "move" })
        }
    } function Da(a, b, c, h) {
        Ea(a, b, a.srl); if (b.More) if (b = d('<div class="awe-morebtn">' + a.mt + "</div>").click(function () {
        h++; var b = d(this); b.after("<div class='awe-loading'><span></span></div>"); b.hide(); var f = [{ name: "isMoreClick", value: !0 }, { name: "page", value: h }]; if (a.tl) var i = a.srl.closest("table").find("thead:first").html() ? !1 : !0, f = f.concat({ name: "isTheadEmpty", value: i }); A(a, a.searchUrl, c.concat(f),
        function (b) { Da(a, awe.readd(b, a), c, h) }, function () { b.closest(".awe-li").remove() })
        }), a.tl) { var f = a.srl.find(".awe-li:not(.awe-morecont):first > td").length, f = d('<tr class="awe-li awe-morecont"><td colspan="' + f + '"></td></tr>'); a.srl.append(f); a.srl.find("tr:last td").append(b) } else a.srl.append('<li class="awe-li awe-morecont"></li>'), a.srl.find("li:last").append(b)
    } function K(a, b) { return a.replace(/{(\d+)}/g, function (a, d) { return "undefined" != typeof b[d] ? b[d] : a }) } function A(a, b, c, d, f) {
        return u(a, {
            url: b,
            data: c, success: d
        }, f)
    } function u(a, b, c) { b.type || (b.type = "post"); b.traditional = !0; return d.ajax(b).always(c).fail(function (b, c, d) { awe.err(a, b, c, d) }) } function va(a) { return !d(a.target).parents(".awe-nonselect").length && !d(a.target).hasClass("awe-nonselect") } function ra(a, b, c) { for (var d = l; a <= b; a++) d += ja(a, c); return d } function ja(a, b, c) { c || (c = a); return K("<a data-p='{0}' class='awe-btn awe-pager-btn {1}'><span class='awe-btn-content'>{2}</span></a>", [a, b != a ? l : r, c]) } function Ka() {
        var a = document.createElement("p");
        a.style.width = "100%"; a.style.height = "200px"; var b = document.createElement("div"), c = b.style; c.position = "absolute"; c.top = "0px"; c.left = "0px"; c.visibility = "hidden"; c.width = "200px"; c.height = "150px"; c.overflow = "hidden"; b.appendChild(a); document.body.appendChild(b); var d = a.offsetWidth; c.overflow = "scroll"; a = a.offsetWidth; d == a && (a = b.clientWidth); document.body.removeChild(b); return d - a
    } var d = jQuery, L = d(document), ba = d(window); d(function () { });
    var z = "<div class='awe-loading'><span></span></div>", q = "change", r = "awe-selected", sa = "." + r, Y = ":input[name]", Fa = "<input type='hidden' name='{0}' value='{1}' />", l = "", wa = Math.max, Ga = Math.min, ca = JSON.stringify, Ha, ka = {}; Ha = { setItem: function (a, b) { ka[a] = b }, getItem: function (a) { return ka[a] }, removeItem: function (a) { delete ka[a] } }; return {
        err: function () { }, errMsg: function () { return l }, test: function () { }, ppk: "awe2_", grid: function (a) {
            function b(a) { return !d(a.target).closest(".awe-grid").is(j) } function c(a, b) {
                var c =
                parseInt(a.attr("colspan"), 10); a.attr("colspan", c + b)
            } function h(a) { for (; a--;) da.prepend('<col class="awe-idn"/>') } function f(b, c) { var d = S + (a.th + 1) - (b - 1) - R; c && (d += a.columns.length - 1); return d } function e(a) { var b = 0; try { 1 == a ? b = Ha : 2 == a ? b = sessionStorage : 3 == a && (b = localStorage) } catch (c) { } return b } function g() { try { T && T.setItem(a.pk, ca([{ pg: a.pg, So: a.So }, B])), U && U.setItem(a.cpk, ca(a.columns)) } catch (b) { } } function i(b) { return a.columns[b.data("i")] } function k(a) {
                y.find(".awe-col").length || y.empty(); y.append(K("<div class='awe-col {3}' data-i='{1}'><div class='awe-il awe-sortable'>{2}{0}</div>{4}</div>",
                [a.H, a.i, P, J[a.Sort], a.Gr ? "<div class='awe-il awe-remb'><i class='awe-rem'></i></div>" : l]))
            } function s(b, c) { b || (b = l); if (d.inArray(c, a.dates) + 1 && "/Date" == b.substr(0, 5)) var F = new Date(parseInt(b.substr(6))), b = d.datepicker.formatDate(a.F, F); return b } function q(a, b) { var c = a, e = [], f; for (f in b) e.push(f); d.each(e, function (a, d) { var w = s(b[d], d); c = c.split("." + d).join(w) }); return c } function v(a, b, c) { if (!b && !c) return a; var d = a.indexOf(">"); return a.substr(0, d) + c + ">" + b + a.substr(d + 1) } function n(a) {
                for (var b = l,
                c = 0; c < a - 1; c++) b += "<td class='awe-idn'></td>"; return b
            } function H(b, c, F, e) {
                var h = l, g = 0; d(a.columns).each(function (d, m) { if (la(m)) return 1; var i = l; !c && (m.F || m.T) ? m.F ? i = eval(m.F)(b, m.P) : m.T && (i = q(m.T, b)) : i = c && m.Ft ? q(m.Ft, b) : s(b[m.P], m.P); var k = l, n = l; if (0 == g) { e && (k += "<i class='awe-ce-ico " + (a.cohc ? l : "awe-ceb") + "'></i>"); var j = f(F), n = n + (" colspan='" + j + "' ") } if ("<td" === i.toString().substring(0, 3)) h += v(i, k, n); else { e && (a.cohc && !g) && (n += " class='awe-ceb'"); if (!i || i == l) i = "&nbsp;"; h += "<td" + n + ">" + k + i + "</td>" } g++ });
                return h
            } function M(b, c, F, e, f, h, i, m) { var g = a.k && b && b[a.k] ? "data-k='" + b[a.k] + "'" : l, m = !m ? c : m; a.st && b && (F += " awe-selectable"); return d(K("<tr {4} data-lvl='{0}' {5} class='{1}'>{2}{3}</tr>", [c, F, n(m), i ? i : H(b, f, m, h), e ? "style='display:none;'" : l, g])).data("model", b) } function ya(b, c, e, h) {
                var h = h || 0, i = !1, g = [], k = b.Header; if (k) {
                    var m = k.Item, n = k.Key + c, j = "", H = 3 == b.Nt; k.IgnorePersistence && (B[n] = k.Collapsed ? 1 : 0); var s = (i = !H && null != B[n] ? B[n] : k.Collapsed) ? " awe-collapsed " : l, s = s + "awe-ghead "; m && (s += "awe-row " + (a.rcf ?
                    q(a.rcf, m) : l)); k.Content && (s += a.cohc ? " awe-ceb" : l, j = "<td colspan='" + f(c, 1) + "'><i class='awe-ce-ico" + (!a.cohc ? " awe-ceb" : l) + "'></i>" + b.Header.Content + "</td>"); k = M(m, c, s, e, 0, 1, j); k.data("i", n); H && k.data("l", 1); g = g.concat(k)
                } !e && i && (e = !0); b.Groups && d.each(b.Groups, function (a, b) { g = g.concat(ya(b, c + 1, e)) }); if (b.Items) { var p = c; 2 != b.Nt && p++; d.each(b.Items, function (b, c) { var d = 0 == (b + h) % 2 ? l : " awe-alt"; a.rcf && (d += " " + q(a.rcf, c)); g = g.concat(M(c, p, "awe-row" + d, e, 0)) }) } b.Footer && (g = g.concat(M(b.Footer, c, "awe-gfoot",
                e, 1, 0, 0, S + 1))); return g
            } function V(b) {
                y.empty(); b || (N.empty(), da.empty()); var c = []; d.each(a.columns, function (a, b) { b.i = a; b.Gd && (c.push(b), b.Sort || (b.Sort = 1)) }); for (var e = 0, f = 0; f < a.columns.length; f++) {
                    var g = a.columns[f]; g.i = f; if (!la(g) && !b && (da.append("<col " + (g.W ? "style='width:" + g.W + "px'" : "") + " data-i='" + f + "' />"), e += g.W || g.Mw, a.sh)) {
                        var i = ""; f || (i = "colspan='" + (a.th + 1) + "'"); g = K("<th {6}><div class='awe-col {3} {4} {5}' unselectable='on' data-i={0} >{1}{2}</div></th>", [f, g.H, g.S ? P : "", g.S ? "awe-sortable" :
                        "", g.G ? "awe-groupable" : "", J[g.Sort], i]); N.append(g)
                    }
                } b || (f = c.length + a.th, h(f), d.each(c, function () { N.prepend('<th class="awe-idn"></th>') }), e += f * ea, Z.css("min-width", e + "px"), X.css("min-width", e + "px")); a.gl = c.length; c.sort(function (a, b) { return a.Gk - b.Gk }); d.each(c, function (a, b) { k(b) }); c.length || y.html(a.gbt); if (!b) N.on("touchstart mousedown", ".awe-groupable", function (b) {
                    function c(a) {
                        !s && p(b); 3 < j || w ? (p(a), a = w ? a.originalEvent.touches[0] : a, Ia = Ga(wa(a.pageX - F, g), La - f.width()), xa = Ga(wa(a.pageY - n, h), i),
                        Ja.css({ left: Ia, top: xa }).show()) : j++
                    } var w = "mousedown" != b.type; w || p(b); var e = w ? b.originalEvent.touches[0] : b, f = d(b.target).closest(".awe-col"), g = y.offset().left, La = g + y.width(), h = y.offset().top, i = h + y.outerHeight(), F = e.pageX - f.offset().left, n = e.pageY - f.offset().top, Ia, xa, Ja = f.clone().addClass("awe-drag").width(f.outerWidth()).hide().appendTo(d("body")), j = 0, s = 0; L.on(w ? "touchmove" : "mousemove", c).one(w ? "touchend" : "mouseup", function () {
                        if (xa < h + y.outerHeight() / 2) {
                            var b = f.data("i"), b = a.columns[b]; if (!b.Gd) {
                                k(b);
                                var w = 0; d.each(a.columns, function (a, b) { b.Gd && b.Gk > w && (w = b.Gk) }); b.Gd = 1; b.Gk = w + 1; V(1); O()
                            }
                        } L.off("touchmove mousemove", c); Ja.remove()
                    })
                }); ma()
            } function ma() {
                var b = j[0], c = null; window.getComputedStyle ? c = window.getComputedStyle(b).direction : b.currentStyle && (c = b.currentStyle.direction); "rtl" == c ? (j.addClass("awe-rtl"), na = 1) : j.addClass("awe-ltr"); b = y.outerHeight(!0); c = j.find(".awe-footer").outerHeight(!0); b = b + c + fa.outerHeight(!0) - 1; c = d("<div></div>"); c.css("overflow-y", "scroll"); c.css("position", "relative");
                c.append("<p/>"); j.append(c); var e = c.find("p").position().left; c.remove(); c = 3 > e ? "right" : "left"; a.h && fa[0] && (E.css("overflow-y", "scroll"), E.height(a.h - b), fa.css("padding-" + c, Ka() + "px"), fa[0].style.display = "none", fa[0].offsetHeight, fa[0].style.display = "block"); a.mh && E.css("min-height", a.mh - b)
            } function u() { V(); V(); R = 0; d.each(a.columns, function (a, b) { la(b) && R++ }); ga.empty().append(ya(a.lsrs.Data, 0, 0)) } function oa(a, b, c, d, e) {
                for (; ;) {
                    var f = a.data("lvl"); if (!f) break; f = parseInt(f, 10); if (f < b) break; if (f == b &&
                    !a.hasClass("awe-gfoot")) break; if (d == f && !a.hasClass("awe-gfoot") || d > f) d = !1; e ? e.push(a) : d || (c ? a.hide() : a.show()); a.hasClass("awe-collapsed") && !d ? oa(a.next(), b, c, f, e) : oa(a.next(), b, c, d, e); break
                }
            } function D(a, b) { b || (b = ga.children("[data-k='" + a + "']")); var c = parseInt(b.data("lvl"), 10); if (!b.length) return []; var d = [b]; oa(b.next(), c, 0, 0, d); return d } function I(b, e) {
                var f = b.data("k"), g = b.hasClass("awe-alt") ? 1 : 0, i = a.lreq.slice(0); i.push({ name: "Key", value: f }); e && (i = i.concat(qa(e))); var k = d(z); b.find("td:not(.awe-idn):first").prepend(k);
                var n = parseInt(b.data("lvl"), 10), m = D(f, b); return A(a, a.url, i, function (e) { e = awe.readd(e, a); if (null != e) { var f = e.Data.Groups && e.Data.Groups.length; if (e.Data.Items && e.Data.Items.length || f) { f = a.th; a.th = wa(f, n - a.gl + (e.Th - 1)); var i = a.th - f; i && (h(i), c(N.find("th:not(.awe-idn):first"), i), d.each(ga.children("tr"), function (a, b) { c(d(b).children(":not(.awe-idn):first"), i) })); b.before(ya(e.Data, n - 1, 0, g)) } d.each(m, function (a, b) { b.remove() }) } }, function () { k.remove() })
            } function O(b) {
                var c, e = [], f = []; d.each(a.columns,
                function (a, b) { b.Gd ? e.push(b) : 0 != b.Sort && f.push(b) }); e.sort(function (a, b) { return a.Gk - b.Gk }); f.sort(function (a, b) { return a.So - b.So }); c = e.concat(f); var h = ["", "asc", "desc"], i = x(a); b && (a.pg = b); i.push({ name: "page", value: a.pg }); for (b = 0; b < c.length; b++) i.push({ name: "SortNames", value: c[b].P }), i.push({ name: "SortDirections", value: h[c[b].Sort] }); for (c = 0; c < e.length; c++) i.push({ name: "Groups", value: e[c].P }), i.push({ name: "Headers", value: e[c].H }); a.sc && i.push({ name: "Cs", value: ca(a.columns) }); j.find(".awe-relbox").append(z);
                ua(a, i); return A(a, a.url, i, function (b) {
                    var c = awe.readd(b, a); null != c && (a.pg = c.Page, a.lsrs = c, b.Cs && (a.columns = JSON.parse(b.Cs)), a.th = c.Th, a.k = !a.ck ? c.Key : a.ck, T || (B = {}), a.dates = c.Dates, S = c.GroupCount, u(), g(), j.find(".awe-pager").html(8 > c.PageCount ? ra(1, c.PageCount, a.pg) : 5 > a.pg ? ra(1, 5, a.pg) + " ... " + ja(c.PageCount, a.pg) : a.pg > c.PageCount - 5 ? ja(1, a.pg) + " ... " + ra(c.PageCount - 5, c.PageCount, a.pg) : ja(1, a.pg) + " ... " + ra(a.pg - 2, a.pg + 2, a.pg) + " ... " + ja(c.PageCount, a.pg)), j.find(".awe-pager a").click(function () {
                        j.find(".awe-pager " +
                        sa).removeClass(r); d(this).addClass(r); a.pg = parseInt(d(this).data("p")); O()
                    })); ma(); Q(a, b, i); a.lreq = i; a.lres = b
                }, function () { j.find(".awe-relbox .awe-loading").remove() })
            } function la(b) { return !a.sgc && b.Gd || b.Hid } var J = ["", "awe-asc", "awe-desc"], P = "<i class='awe-sord'></i>", j = d("#" + a.i); a.v = j; j.data("o", a); var y = j.find(".awe-groupbar"), da = j.find("colgroup"), $ = da.first(), aa = da.last(), E = j.find(".awe-content"), X = j.find(".awe-tablw"), ga = j.find(".awe-tbody"), na, fa = j.find(".awe-header"), Y = j.find(".awe-hcon"),
            Z = j.find(".awe-colw"), N = j.find(".awe-hrow"), G, ea = 16, R, B = {}; a.So = 100; a.pg = 1; var C = a.pk; a.pk = awe.ppk + (!C ? a.i : C) + a.prs; a.cpk = awe.ppk + "c_" + (!C ? a.i : C) + a.cps; var S = 0, ka = d.extend(!0, {}, a), ta = null, pa = a.st; if (pa) j.on("click", ".awe-row", function (a) {
                if (!b(a) && va(a)) {
                    var c = 1; if (a.shiftKey && null !== ta && 2 == pa) { a.ctrlKey || d(this).parent().children().removeClass(r); var a = d(this).index(), e = ta.index(); a > e && (a = -(e = (a += e) - e) + a); d(this).parent().children().slice(a, e + 1).addClass(r) } else a.ctrlKey && 2 == pa || 3 == pa ? (d(this).toggleClass(r),
                    ta = d(this)) : 0 < pa && (ta = d(this), d(this).siblings(sa).removeClass(r), d(this).hasClass(r) ? c = 0 : d(this).addClass(r)); c && (window.getSelection ? window.getSelection().empty ? window.getSelection().empty() : window.getSelection().removeAllRanges && window.getSelection().removeAllRanges() : document.selection && document.selection.empty()); j.trigger("aweselect")
                }
            }); var T = e(a.prs), U = e(a.cps), t = function () { }; j.data("api", t); t.update = function (a, b) { return I(ga.children("[data-k='" + a + "']"), b) }; t.select = D; t.lay = ma; t.render = u;
            t.persist = g; t.clearpersist = function () { B = {}; T && T.removeItem(a.pk); U && U.removeItem(a.cpk) }; t.getSelection = function () { return d(".awe-row" + sa, j).map(function () { return d(this).data("model") }).get() }; t.renderRow = function (b, c) { var d = a.gl + 1 + a.th; return M(b, !c ? d : c, "awe-row") }; t.getRequest = function () { return a.lreq }; t.getResult = function () { return a.lres }; t.reset = function () { B = {}; a = d.extend(!0, {}, ka); j.data("o", a); V(1); O(1) }; t.load = function (b) {
                if (b && (b.params && (a.params = b.params), b.oparams && (a.oparams = b.oparams),
                b.group && d.each(a.columns, function (a, c) { var e = d.inArray(c.P, b.group) + 1; e ? (c.Gd = 1, c.Gk = e) : c.Gd = 0 }), b.sort)) { var c = 0; d.each(a.columns, function (a, e) { var f = 0; d.each(b.sort, function (a, b) { if (e.P == b.Prop) return f = b, !1 }); f ? (e.Sort = f.Sort, e.So = c++) : e.Sort = 0 }) } V(1); return O()
            }; ba.resize(ma); j.find(".awe-reload").click(function () { t.reset() }); j.on("click", ".awe-remb", function (c) { if (!b(c)) { var c = i(d(this).closest(".awe-col")), e = c.Gd = 0; d.each(a.columns, function (a, b) { b.So < e && (e = b.So) }); c.So = e - 1; g(); V(1); O() } });
            ga.on("click", ".awe-ceb", function (a) { if (!b(a)) { var a = d(this).closest(".awe-ghead"), c = parseInt(a.data("lvl"), 10), e = a.next(), f = a.data("i"); a.hasClass("awe-collapsed") ? (a.data("l") && (a.data("l", 0), I(a)), a.removeClass("awe-collapsed"), oa(e, c, !1), B[f] = 0) : (a.addClass("awe-collapsed"), oa(e, c, !0), B[f] = 1); g() } }); j.on("click", ".awe-sortable", function (c) {
                if (!b(c)) {
                    za = 0; c = d(this); c.parent().hasClass("awe-col") && (c = c.parent()); var e = i(c), f = e.Sort + 1; 3 == f && (f = e.Gd ? 1 : 0); e.Sort = f; j.find("[data-i=" + c.data("i") + "]").removeClass("awe-asc awe-desc").addClass(J[f]);
                    e.Gd || (a.s && d.each(a.columns, function (a, b) { if (b.Gd || b.P == e.P) return 1; b.Sort = 0; N.find("[data-i=" + a + "]").removeClass("awe-asc awe-desc") }), 1 == f && (i(c).So = ++a.So)); g(); O()
                }
            }); E.on("scroll", function () { Y.scrollLeft(d(this).scrollLeft()) }); a.nsts && d.each(a.nsts, function (c, e) {
                ga.on("click", "." + e.C, function (c) {
                    if (!b(c)) {
                        var c = d(this).closest(".awe-row"), i = c.find("." + e.C), g = c.nextUntil(":not(.awe-nest)", ".n-" + e.C); c.nextUntil(":not(.awe-nest)", ":not(.n-" + e.C + ")").map(function (a, b) { d(b).data("api").close() });
                        if (g.length) c = g.first(), g = c.data("api"), c.is(":visible") ? e.T && g.close() : g.open(); else {
                            var g = c.data("lvl"), h = M(0, g, "awe-nest n-" + e.C, 0, 0, 0, "<td colspan='" + f(g, 1) + "' class='awe-nestcell'></td>"), g = function () { }; g.open = function () { i.addClass("awe-on"); h.show() }; g.close = function () { i.removeClass("awe-on"); e.L ? h.hide() : h.remove() }; h.data("api", g); c.after(h); g.open(); var k = h.find(".awe-nestcell"); if (e.U) { var n = d(z); k.append(n); A(a, e.U, { key: c.data("model")[a.k] }, function (a) { k.html(a) }, function () { n.remove() }) } else e.F &&
                            eval(e.F)(c, h, k)
                        }
                    }
                })
            }); var za = 0, Aa; N.on("mousemove", "th:not(.awe-idn)", function (b) {
                var c = d(b.target).closest("th"), e = c.find(".awe-col").data("i"), f = c.offset().left, i = c.outerWidth(), h = f - 5; za++; if (!(3 > za) && (b.pageX > i / 2 + f ? (h += i, e == a.columns.length - 1 && !na && (h -= 5), na && e--) : na || e--, -1 < e && a.columns[e].R)) {
                    if (!G) {
                        G = d('<div class="awe-resh"/>').appendTo("body"); var k = function (a) { a = d(a.target); !a.is(G) && (!a.closest(".awe-header").length && !Aa) && (L.off("mousemove", k), G.remove(), G = 0) }; L.on("mousemove", k); G.on("mousedown",
                        function (b) {
                            p(b); var c = d(this).width(20).data("i"); Aa = 1; var e = da.find("[data-i=" + c + "]"), f = N.find("[data-i=" + c + "]").parent(), h = b.pageX, i = 0, k = 0, n = a.columns[c].W, j = ea * (a.th + a.gl), s = f.outerWidth(), H = a.columns[c].Mw; d.each(a.columns, function (a, b) { la(b) || (j += b.W || b.Mw, a != c && !b.W && (k = 1)) }); var l = !c ? a.th * ea : 0; n ? n += l : (n = s, j += n - (H + a.th * ea)); var M = Y.width(), q = function (b) {
                                b.pageX < L.width() - 10 && G.css({ left: b.pageX - 10, top: b.pageY - 10 }); b = b.pageX - h; na && (b *= -1); var f = 0; if (k) f = n + b; else {
                                    var f = M - (s + b), g = j - n; f < g && (f =
                                    g); f = (s + b) * (g / f || 1)
                                } 1 > f && (f = 1); var m = 1; f < H && (m = H / f, f *= m); f -= l; e.css("width", f + "px"); var p = a.columns[c].W = f, b = ea * (a.th + a.gl), b = (j - (b + (n - l))) * m + f + b; if (!k && (1 < m || i) && M >= b + 5) d.each(a.columns, function (b, d) { if (b != c && (a.columns[b].R && !la(d)) && d.W) { i || (d.ciw = d.W); var e = d.ciw * m; $.find("[data-i=" + b + "]").css("width", e + "px"); aa.find("[data-i=" + b + "]").css("width", e + "px"); d.W = e; p += e } }), p += ea * (a.th + a.gl), i = 1, 1 >= m && (i = 0); else { if (1 < m) return; p += j - (n - l) } X.css("min-width", p + "px"); Z.css("min-width", p + "px"); e.trigger("awecolresize")
                            };
                            L.on("mousemove", q); L.one("mouseup", function () { Aa = 0; L.off("mousemove", q); G.width(10); g() })
                        })
                    } G.data("i", e).css({ left: h, top: c.offset().top, height: c.outerHeight() })
                }
            }); if (T && (C = T.getItem(a.pk))) if ((C = d.parseJSON(C)) && 2 == C.length) { var ia = C[0]; a.pg = ia.pg; a.So = ia.So; B = C[1] } U && U.getItem(a.cpk) && (a.columns = d.parseJSON(U.getItem(a.cpk))); V(); ma(); a.l && W(a, function () { O() }); ha(a, function () { W(a, function () { O(1) }) }, !a.lpc)
        }, form: function (a) {
            var b = "." + a.cl; d(document).off("submit.awe", b).on("submit.awe", b, function (b) {
                function h() {
                    a.notok =
                    1; if (a.ua) { var b = a, c = a.u, d = f.attr("action"); u(b, { url: !c ? d : c, data: f.serialize(), success: function (b) { "object" == typeof b || !a.ff ? (a.sf && a.sf(b), f.trigger("aweformsuccess", b)) : f.html(b); a.notok = 0 } }) } else f.data("aweex", 1), a.u && f.attr("action", a.u), f.submit()
                } var f = d(this); if (!f.data("aweex") && (p(b), !(a.bf && !1 === a.bf(f)) && !a.notok)) {
                    if (a.c) return a.p.d = d("<div>" + a.ms + "</div>"), a.p.btns = [{ text: a.yes, click: function () { h(); d(this).data("api").close() } }, { text: a.no, click: function () { d(this).data("api").close() } }],
                    I(a), a.p.d.data("api").open(), d(".ui-dialog-buttonset button").blur(), !1; h()
                }
            })
        }, autocomplete: function (a) {
            a.v = a.d = d("#" + a.i); a.v.data("numeric") && awe.numeric(a.d); var b = null; a.k && (b = d("#" + a.k)); a.d.autocomplete({ minLength: a.ml, source: function (b, h) { var f = x(a); u(a, { url: a.url, dataType: "json", data: f, success: function (a) { h(d.map(a, function (a) { return { label: a.C, value: a.C, id: a.K } })) } }) } }); a.d.bind("autocompleteselect", function (c, d) { b && b.val(d.item ? d.item.id : null).trigger(q); a.d.trigger(q) }); b && a.d.keyup(function (a) {
                "13" !=
                a.which && b.val(null).trigger(q)
            })
        }, numeric: function (a) { a.keydown(function (a) { var c = a.which; 46 == c || (8 == c || 9 == c || 27 == c || 13 == c || 65 == c && !0 === a.ctrlKey || 35 <= c && 39 >= c) || ((48 > c || 57 < c) && (96 > c || 105 < c) ? a.preventDefault() : !0 === a.shiftKey && p(a)) }) }, txt: function (a) { a.d = a.v = d("#" + a.i); a.v.data("numeric") && awe.numeric(a.d) }, dtp: function (a) {
            D(a); var b = { dateFormat: a.format, changeMonth: a.cm, changeYear: a.cy, onClose: function () { R(a.v) }, onSelect: function () { a.v.change(); a.f.find(".awe-dpbtn").focus() } }; a.min && (b.minDate =
            a.min); a.max && (b.maxDate = a.max); a.dfd && (b.defaultDate = a.dfd); a.rtl && (b.isRTL = a.rtl); a.d.datepicker(b); a.f.find(".awe-dpbtn").click(function (b) { p(b); a.v.datepicker("show").blur(); d(this).focus() }); a.f.find(".awe-clearbtn").click(function (b) { p(b); a.d.val("").change() })
        }, ajaxList: function (a) { function b(b) { b || (b = 1); return E(a, [], b, 1) } a.v = d("#" + a.i); a.srl = a.tl ? a.v.find(".awe-srl") : a.v; a.mode = "s"; P(a, b); W(a, b); ha(a, function () { W(a, function () { b(1) }) }, !a.lpc) }, rcbl: function (a, b) {
            d.each(b, function (b, d) {
                a.d.append("<li><input " +
                (d.S ? 'checked="checked"' : l) + 'id="' + a.i + "_item_" + b + '" name="' + a.v.data("name") + '" value="' + d.V + '" type="checkbox"/><label class="awe-label" for="' + a.i + "_item_" + b + '">' + d.T + "</label></li>")
            })
        }, checkboxList: function (a) {
            function b(b) { var h = x(a); return Z(a, h, function (f) { a.d.empty(); var e = awe.readd(f, a); null != e && awe.rcbl(a, e); e = ca(d(a.d.find("input:checked")).map(function () { return d(this).val() }).get()); "[]" == e && (e = ""); e != a.v.val() ? (a.v.val(e), v(a, b)) : b && a.v.trigger("awepch", b); Q(a, f, h) }) } D(a); X(a, b); P(a,
            b); a.d.on(q, "input", function () { var b = ca(d(a.d.find("input:checked")).map(function () { return d(this).val() }).get()); "[]" == b && (b = ""); a.v.val(b); v(a) })
        }, rrl: function (a, b) { d.each(b, function (b, d) { var f = ""; !0 == d.S && (f = 'checked="checked"'); a.d.append('<li><input type="radio" value="' + d.V + '" name="' + a.i + '" id="' + a.i + "_item_" + b + '"' + f + ' /><label class="awe-label" for="' + a.i + "_item_" + b + '" >' + d.T + "</label></li>") }) }, radioList: function (a) {
            function b(b) {
                var d = x(a); return Z(a, d, function (f) {
                    a.d.empty(); var e = awe.readd(f,
                    a); null != e && awe.rrl(a, e); var e = "", g = a.d.find("input:radio:checked"); g.length && (e = g.val()); a.v.val() != e ? (a.v.val(e), v(a, b)) : b && a.v.trigger("awepch", b); Q(a, f, d)
                })
            } D(a); X(a, b); P(a, b); a.d.on(q, "input", function () { a.v.val(a.d.find("input:checked").val()); v(a) })
        }, lookup: function (a) {
            function b() {
                var b = d("<div class='awe-lookup-popup'><div class='awe-search'></div><div class='awe-list awe-srlcont'>" + (a.tl ? "<table class='awe-ajaxlist awe-lookup-list awe-selectable'><thead></thead><tbody class='awe-srl'></tbody></table>" :
                "<ul class='awe-ajaxlist awe-lookup-list awe-srl awe-selectable'></ul>") + "</div></div>"); a.p.d = b; a.p.btns = [{ text: a.ok, click: function () { a.v.val(b.find(sa).data("val")); v(a); a.ms = 0; b.data("api").close() } }, { text: a.cancel, click: function () { d(this).data("api").close() } }]; I(a); a.fm = 0; a.soc = 1; b.bind("aweclose", function () { a.ms && b.find(".awe-li").removeClass(r); a.ms = 0; a.f.find(".awe-openbtn").focus() }); a.srl = b.find(".awe-srl"); a.srl.on("click", ".awe-li:not(.awe-morecont)", function (c) {
                    var e = d(this); va(c) && (e.toggleClass(r),
                    b.find(".awe-li").not(e).removeClass(r), a.ms = 1)
                }).on("dblclick", ".awe-li:not(.awe-morecont)", function (c) { va(c) && (a.v.val(d(this).addClass(r).data("val")), v(a), a.ms = 0, b.data("api").close()) }); b.bind("aweresize", f)
            } function c(b) { a.d.empty(); if (a.v.val()) { e = 1; a.d.html(z); var c = x(a); A(a, a.getUrl, c, function (d) { a.d.empty(); var e = awe.readd(d, a); null != e && a.d.html(e.C); a.hi && 1 != b && a.d.addClass("awe-changing").removeClass("awe-changing", 1E3); Q(a, d, c) }, function () { e = 0 }) } } function h() {
                function b() { E(a, a.fm.find(Y).serializeArray()) }
                if (a.fm.find("[data-notr]").length) a.fm.one("aweready", b); else b()
            } function f() { var b = a.p.d, c = b.find(".awe-search:first").outerHeight(!0), d = S(b.find(".awe-srlcont:first")), c = b.height() - (c + d + 10); c < a.p.mlh && (c = a.p.mlh); b.find(".awe-list").css("height", c + "px") } D(a); a.soc = 1; a.mode = "s"; var e; ha(a, function () { a.soc = !0 }); c(1); a.v.change(c); b(); var g = function () { }; g.initPopup = b; g.search = h; a.v.data("api", g); a.f.find(".awe-clearbtn").click(function (b) { p(b); a.v.val(""); v(a); a.soc = !0 }); a.f.find(".awe-openbtn").click(function (b) {
                p(b);
                if (!e) { var c = a.p.d; c.data("api").open(); a.fm || (a.fm = c.find(".awe-search"), a.fm.on(q, "*", f).submit(function (a) { p(a); a.stopPropagation(); h() })); a.soc && (a.fm.html() ? h() : (a.sf ? A(a, a.sf, {}, function (b) { a.fm.html(b); h(); f(); J(c); awe.ff(a) }) : (a.fm.html(K('<input type="text" name="search" class="awe-searchtxt"/><button type="button" class="awe-searchbtn awe-btn">{0}</button>', [a.st])), h(), J(c)), ia.call(this, a, h))); a.soc = !1; f(); awe.ff(a) }
            })
        }, add: function (a) {
            function b(b) {
                var h = x(a); return Z(a, h, function (f) {
                    a.d.empty();
                    var e = awe.readd(f, a); null != e && d.each(e, function (b, c) { var d = l; !0 == c.S && (d = "selected = 'selected'"); a.d.append("<option " + d + ' value="' + c.V + '">' + c.T + "</option>") }); e = a.d.val(); "1" == a.v.data("notr") ? (a.v.val(e), a.v.data("notr", 0), a.v.removeAttr("data-notr"), a.v.trigger("aweready")) : a.v.val() != e ? (a.v.val(e), v(a, b)) : b && a.v.trigger("awepch", b); Q(a, f, h)
                })
            } D(a); X(a, b); P(a, b); a.d.keyup(function () { d(this).change() }).change(function () { a.v.val() != a.d.val() && (a.v.val(a.d.val()), v(a)) })
        }, readd: function (a, b) {
            return "object" !=
            typeof a ? (awe.err(b, { responseText: a }), null) : ("object" == typeof a || "string" == typeof a) && null != a ? a : null
        }, ip: function (a) { a.f = d("#" + a.i); a.f.data("o", a) }, open: function (a, b) { var c = d("#" + a + "-awein").data("o"), c = d.extend(!0, {}, c); d.extend(!0, c, b); if ("op" == c.type) awe.op({}, c); else if ("pf" == c.type) awe.pf({}, c); else throw a + " not initialized"; }, ff: function (a) { a.p.d.find(":tabbable:first").focus() }, pf: function (a, b) {
            p(a); var c = d("<div/>"); c.on("submit", "form", function (a) {
                p(a); if (!a.awesh && (a.awesh = 1, !b.notok)) {
                    b.notok =
                    1; var a = d(this), e = a.attr("method"); u(b, { url: a.attr("action"), data: a.serialize(), success: function (a) { "object" == typeof a ? (b.sf && b.sf(a, c), c.trigger("awepopupformsuccess", a), b.cs && c.data("api").close(), b.rs && location.reload(!0)) : c.html(a) }, type: e }, function () { b.notok = 0 })
                }
            }); var h = d(z); c.html(h); u(b, { type: "get", data: x(Ba(b)), url: b.u, cache: !1, success: function (a) { c.html(a); awe.ff(b) } }, function () { h.remove() }); for (var f = [], e = 0; e < b.b.length; e += 2) f.push({ text: b.b[e], click: b.b[e + 1] }); b.udb && (f = f.concat([{
                text: b.ot,
                click: function () { c.find("form:first").submit() }
            }, { text: b.ct, click: function () { c.data("api").close() } }])); b.p.d = c; b.p.btns = f; I(b); c.data("api").open()
        }, op: function (a, b) { p(a); var c = d("<div/>"); b.c && c.html(b.c); var h = d(z); b.u && (c.append(h), u(b, { type: "get", data: x(Ba(b)), url: b.u, cache: !1, success: function (a) { c.html(a) } }, function () { h.remove() })); for (var f = [], e = 0; e < b.b.length; e += 2) f.push({ text: b.b[e], click: b.b[e + 1] }); b.p.d = c; b.p.btns = f; I(b); c.data("api").open() }, autoSize: 1, popup: function (a) {
            var b = a.p, c = b.d;
            b.mlh = 0; var h = awe.autoSize, f = b.f, a = !0; b.r || (b.r = !1); f && (a = b.r = !1, b.m = !0); c.dialog({ draggable: a, width: b.w, height: b.h, modal: b.m, resizable: b.r, buttons: b.btns, autoOpen: !1, title: b.t, resizeStop: function () { b.w = c.dialog("option", "width"); b.h = c.dialog("option", "height"); b.p = c.dialog("option", "position") }, dragStop: function () { b.p = c.dialog("option", "position") } }); c.on("dialogclose", function () { d(this).trigger("aweclose") }).on("dialogresize", function () { d(this).trigger("aweresize") }); a = "awe-uidialog"; b.pc && (a = a +
            " " + b.pc); c.dialog("option", { dialogClass: a }); var e = function () { }; if (f || h) e = function (a) { if (!a || a.target == window || a.target == document) { var a = ba.height(), d = ba.width(), a = { height: b.h > a - 5 || f ? a - 20 : b.h, width: b.w > d - 10 || f ? d - 10 : b.w }; !f && b.p && (a.position = b.p); c.dialog("option", a).trigger("aweresize") } }, ba.on("resize", e), e(), c.on(q, e); c.on("aweclose", function () { b.isOpen = 0; b.cl && b.cl(); b.dntr || ((h || f) && ba.off("resize", e), c.find("*").remove(), c.remove()) }); var g = function () { }; g.open = function () {
                c.dialog("open"); b.isOpen =
                1; e()
            }; g.close = function () { c.dialog("close") }; g.destroy = function () { g.close(); ba.off("resize", e); c.remove() }; c.data("api", g)
        }, multilookup: function (a) {
            function b() {
                var b = d("<div class='awe-multilookup-popup'><div class='awe-search'></div><div class='awe-list awe-srlcont'>" + (a.tl ? "<table class='awe-ajaxlist awe-lookup-list'><thead></thead><tbody class='awe-srl'></tbody></table>" : "<ul class='awe-ajaxlist awe-lookup-list awe-srl'></ul>") + "</div><div class='awe-list awe-selcont' >" + (a.tl ? "<table class='awe-ajaxlist awe-lookup-list'><thead></thead><tbody class='awe-sel'></tbody></table>" :
                "<ul class='awe-ajaxlist awe-lookup-list awe-sel'></ul>") + "</div></div>"); a.p.d = b; a.p.btns = [{ text: a.ok, click: function () { a.v.val(g().length ? ca(g()) : null); k.empty(); var b = g(); d.each(b, function (a) { k.append(K(Fa, [l, String(b[a]).replace(/&/g, "&amp;").replace(/"/g, "&quot;").replace(/'/g, "&#39;").replace(/</g, "&lt;").replace(/>/g, "&gt;")])) }); v(a, 1); a.ms = 0; d(this).data("api").close() } }, { text: a.cancel, click: function () { d(this).data("api").close() } }]; I(a); a.fm = 0; a.soc = 1; b.bind("aweclose", function () {
                    a.ms && (a.soc =
                    !0); a.ms = 0; a.f.find(".awe-openbtn").focus()
                }); a.srl = b.find(".awe-srl"); a.sel = b.find(".awe-sel"); a.srl.on("click", ".awe-movebtn", h); a.sel.on("click", ".awe-movebtn", f); a.dg && (b.find(".awe-srlcont").droppable({ accept: "#" + a.p.i + " .awe-selcont .awe-li", activeClass: "awe-highlight", drop: function (b, c) { c.draggable.prependTo(a.srl); a.ms = 1 } }), b.find(".awe-selcont").droppable({ accept: "#" + a.p.i + " .awe-srlcont .awe-li", activeClass: "awe-highlight", drop: function (b, c) { c.draggable.prependTo(a.sel); a.ms = 1 } })); b.bind("aweresize",
                e)
            } function c() { function b() { var c = a.fm.find(Y).serializeArray(); a.loaded ? E(a, aa(g(), "selected").concat(c)) : E(a, $(a.v, "selected").concat(c)) } if (a.fm.find("[data-notr]").length) a.fm.on("aweready", b); else b() } function h() { var b = d(this); setTimeout(function () { b.closest(".awe-li").prependTo(a.sel); a.ms = 1 }, 1) } function f() { var b = d(this); setTimeout(function () { b.closest(".awe-li").prependTo(a.srl); a.ms = 1 }, 1) } function e() {
                var b = a.p.d, c = b.height() - (b.find(".awe-search").outerHeight(!0) + S(b.find(".awe-srlcont")) +
                S(b.find(".awe-selcont")) + 10); c < a.p.mlh && (c = a.p.mlh); b.find(".awe-list").css("height", 0.5 * c + "px")
            } function g() { return a.sel.find(".awe-li").map(function () { return d(this).data("val") }).get() } function i(b, c) {
                var e = a.d.empty(); if (a.v.val()) {
                    r = 1; e.html("<li>" + z + "</li>"); var f = x(a); A(a, a.getMultipleUrl, f, function (g) {
                        e.empty(); c && k.empty(); var h = awe.readd(g, a); h && (d.each(h, function (a, b) { e.append("<li>" + b.C + "</li>"); c && k.append(K(Fa, [l, b.K])) }), e.change(), a.hi && !b && a.d.addClass("awe-changing").removeClass("awe-changing",
                        1E3)); Q(a, g, f)
                    }, function () { r = 0 })
                } else k.empty().append("<input type='checkbox' name='" + l + "' />")
            } D(a); a.soc = 1; var k = a.v.next(), l = a.v.data("name"), r; ha(a, function () { a.soc = !0 }); a.v.on(q, function (b, c) { a.soc = 1; i(0, !c) }); i(1); b(); var u = function () { }; u.initPopup = b; a.v.data("api", u); a.f.find(".awe-clearbtn").click(function (b) { p(b); k.empty(); a.v.val(""); v(a); R(a.v); a.soc = !0 }); a.f.find(".awe-openbtn").click(function (b) {
                p(b); if (!r) {
                    var d = a.p.d; d.data("api").open(); a.fm || (a.fm = d.find(".awe-search"), a.fm.on(q,
                    "*", e).submit(function (a) { p(a); a.stopPropagation(); c() })); if (a.soc) {
                        a.loaded = 0; a.fm.html() ? c() : (a.sf ? A(a, a.sf, {}, function (b) { a.fm.html(b); c(); e(); J(d); awe.ff(a) }) : (a.fm.html(K('<input type="text" name="search" class="awe-searchtxt"/><button type="button" class="awe-searchbtn awe-btn">{0}</button>', [a.st])), c(), J(d)), ia.call(this, a, c)); a.sel.html(""); Ca(a.tl, a.sel); b = x(a, a); b = b.concat($(a.v, "selected")); if (a.tl) var f = a.srl.closest("table").find("thead:first").html() ? !1 : !0, b = b.concat({
                            name: "isTheadEmpty",
                            value: f
                        }); A(a, a.selectedUrl, b, function (b) { a.sel.empty(); b = awe.readd(b, a); null != b && (Ea(a, b, a.sel), a.loaded = 1) })
                    } awe.ff(a); a.soc = !1; e()
                }
            })
        }
    }
}();
