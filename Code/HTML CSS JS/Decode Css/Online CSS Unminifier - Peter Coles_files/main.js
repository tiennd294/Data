(function(d, w, undefined) {
    d.getElementById('nav-toggle').onclick = function() {
        var elt = d.body,
            r = /(^|\s+)show-nav(\s+|$)/;
        if (r.test(elt.className)) {
            elt.className = elt.className.replace(r, '');
        } else {
            elt.className += (elt.className ? ' ' : '') + 'show-nav';
        }
    };
})(document, this);
