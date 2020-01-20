.nav {
  text-align: center;
}

.img--avatar, .img--logo {
  margin: 0 auto;
}

.link, .nav__item a {
  text-decoration: none;
}

.headline--primary {
  color: #58e1c1;
  font-weight: 700;
  font-size: 1.7777777778em;
  line-height: 1.125;
  margin: 1.1111111111em 0 2.2222222222em 0.8333333333em;
}

.headline--secondary {
  font-weight: 100;
  margin: 0 0 0.8333333333em 0.8333333333em;
  color: silver;
}

.nav__item a:active, .nav__item a:hover {
  background-color: #58e1c1;
  border-radius: 5px;
  color: #fff;
  font-weight: 400;
}

[class^=btn--] {
  width: 100%;
  padding: 0.7222222222em 0;
  font-family: "Neue Helvetica", Helvetica, sans-serif;
  font-weight: 400;
  text-transform: uppercase;
  color: #fff;
  border: none;
  border-radius: 5px;
  display: flex;
  flex-direction: column;
  align-items: center;
  margin-bottom: 20px;
}

/*! normalize.css v8.0.1 | MIT License | github.com/necolas/normalize.css */
/* Document
   ========================================================================== */
/**
 * 1. Correct the line height in all browsers.
 * 2. Prevent adjustments of font size after orientation changes in iOS.
 */
html {
  line-height: 1.15;
  /* 1 */
  -webkit-text-size-adjust: 100%;
  /* 2 */
}

/* Sections
   ========================================================================== */
/**
 * Remove the margin in all browsers.
 */
body {
  margin: 0;
}

/**
 * Render the `main` element consistently in IE.
 */
main {
  display: block;
}

/**
 * Correct the font size and margin on `h1` elements within `section` and
 * `article` contexts in Chrome, Firefox, and Safari.
 */
h1 {
  font-size: 2em;
  margin: 0.67em 0;
}

/* Grouping content
   ========================================================================== */
/**
 * 1. Add the correct box sizing in Firefox.
 * 2. Show the overflow in Edge and IE.
 */
hr {
  box-sizing: content-box;
  /* 1 */
  height: 0;
  /* 1 */
  overflow: visible;
  /* 2 */
}

/**
 * 1. Correct the inheritance and scaling of font size in all browsers.
 * 2. Correct the odd `em` font sizing in all browsers.
 */
pre {
  font-family: monospace, monospace;
  /* 1 */
  font-size: 1em;
  /* 2 */
}

/* Text-level semantics
   ========================================================================== */
/**
 * Remove the gray background on active links in IE 10.
 */
a {
  background-color: transparent;
}

/**
 * 1. Remove the bottom border in Chrome 57-
 * 2. Add the correct text decoration in Chrome, Edge, IE, Opera, and Safari.
 */
abbr[title] {
  border-bottom: none;
  /* 1 */
  text-decoration: underline;
  /* 2 */
  text-decoration: underline dotted;
  /* 2 */
}

/**
 * Add the correct font weight in Chrome, Edge, and Safari.
 */
b,
strong {
  font-weight: bolder;
}

/**
 * 1. Correct the inheritance and scaling of font size in all browsers.
 * 2. Correct the odd `em` font sizing in all browsers.
 */
code,
kbd,
samp {
  font-family: monospace, monospace;
  /* 1 */
  font-size: 1em;
  /* 2 */
}

/**
 * Add the correct font size in all browsers.
 */
small {
  font-size: 80%;
}

/**
 * Prevent `sub` and `sup` elements from affecting the line height in
 * all browsers.
 */
sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sub {
  bottom: -0.25em;
}

sup {
  top: -0.5em;
}

/* Embedded content
   ========================================================================== */
/**
 * Remove the border on images inside links in IE 10.
 */
img {
  border-style: none;
}

/* Forms
   ========================================================================== */
/**
 * 1. Change the font styles in all browsers.
 * 2. Remove the margin in Firefox and Safari.
 */
button,
input,
optgroup,
select,
textarea {
  font-family: inherit;
  /* 1 */
  font-size: 100%;
  /* 1 */
  line-height: 1.15;
  /* 1 */
  margin: 0;
  /* 2 */
}

/**
 * Show the overflow in IE.
 * 1. Show the overflow in Edge.
 */
button,
input {
  /* 1 */
  overflow: visible;
}

/**
 * Remove the inheritance of text transform in Edge, Firefox, and IE.
 * 1. Remove the inheritance of text transform in Firefox.
 */
button,
select {
  /* 1 */
  text-transform: none;
}

/**
 * Correct the inability to style clickable types in iOS and Safari.
 */
button,
[type=button],
[type=reset],
[type=submit] {
  -webkit-appearance: button;
}

/**
 * Remove the inner border and padding in Firefox.
 */
button::-moz-focus-inner,
[type=button]::-moz-focus-inner,
[type=reset]::-moz-focus-inner,
[type=submit]::-moz-focus-inner {
  border-style: none;
  padding: 0;
}

/**
 * Restore the focus styles unset by the previous rule.
 */
button:-moz-focusring,
[type=button]:-moz-focusring,
[type=reset]:-moz-focusring,
[type=submit]:-moz-focusring {
  outline: 1px dotted ButtonText;
}

/**
 * Correct the padding in Firefox.
 */
fieldset {
  padding: 0.35em 0.75em 0.625em;
}

/**
 * 1. Correct the text wrapping in Edge and IE.
 * 2. Correct the color inheritance from `fieldset` elements in IE.
 * 3. Remove the padding so developers are not caught out when they zero out
 *    `fieldset` elements in all browsers.
 */
legend {
  box-sizing: border-box;
  /* 1 */
  color: inherit;
  /* 2 */
  display: table;
  /* 1 */
  max-width: 100%;
  /* 1 */
  padding: 0;
  /* 3 */
  white-space: normal;
  /* 1 */
}

/**
 * Add the correct vertical alignment in Chrome, Firefox, and Opera.
 */
progress {
  vertical-align: baseline;
}

/**
 * Remove the default vertical scrollbar in IE 10+.
 */
textarea {
  overflow: auto;
}

/**
 * 1. Add the correct box sizing in IE 10.
 * 2. Remove the padding in IE 10.
 */
[type=checkbox],
[type=radio] {
  box-sizing: border-box;
  /* 1 */
  padding: 0;
  /* 2 */
}

/**
 * Correct the cursor style of increment and decrement buttons in Chrome.
 */
[type=number]::-webkit-inner-spin-button,
[type=number]::-webkit-outer-spin-button {
  height: auto;
}

/**
 * 1. Correct the odd appearance in Chrome and Safari.
 * 2. Correct the outline style in Safari.
 */
[type=search] {
  -webkit-appearance: textfield;
  /* 1 */
  outline-offset: -2px;
  /* 2 */
}

/**
 * Remove the inner padding in Chrome and Safari on macOS.
 */
[type=search]::-webkit-search-decoration {
  -webkit-appearance: none;
}

/**
 * 1. Correct the inability to style clickable types in iOS and Safari.
 * 2. Change font properties to `inherit` in Safari.
 */
::-webkit-file-upload-button {
  -webkit-appearance: button;
  /* 1 */
  font: inherit;
  /* 2 */
}

/* Interactive
   ========================================================================== */
/*
 * Add the correct display in Edge, IE 10+, and Firefox.
 */
details {
  display: block;
}

/*
 * Add the correct display in all browsers.
 */
summary {
  display: list-item;
}

/* Misc
   ========================================================================== */
/**
 * Add the correct display in IE 10+.
 */
template {
  display: none;
}

/**
 * Add the correct display in IE 10.
 */
[hidden] {
  display: none;
}

* {
  -moz-box-sizing: border-box;
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

ul {
  list-style: none;
}

p {
  line-height: 1;
  color: red;
}

.form__label--hidden {
  visibility: hidden;
}
.form__input {
  display: flex;
  justify-content: center;
  width: 90%;
  margin: 0 auto;
  border: none;
  border-bottom: 0.3333333333em solid #58e1c1;
  padding: 0.6666666667em;
  outline: none;
}

.nav__item a {
  display: block;
  padding: 0.8888888889em;
  color: #666666;
}
.img--logo {
  display: block;
  padding: 2.5em 0;
}
.img--frame {
  padding: 0.8333333333em;
  border: solid 1px silver;
  width: 100%;
  margin-top: 40px;
}
.img--avatar {
  display: block;
  padding: 1.6666666667em 0;
}

.container {
  width: 80%;
  margin: 0 auto;
  font-family: "Neue Helvetica", Helvetica, sans-serif;
  font-size: 18px;
  font-weight: 300;
  color: #737373;
}

.grid__row {
  margin-bottom: 50px;
}

.grid__col--1.theme__colors {
  display: flex;
  border-radius: 5px;
  border: none;
  font-size: 0.8888888889em;
  color: #737373;
  font-weight: 400;
  padding: 0.8333333333em 0.7222222222em 0.8333333333em;
  margin: 0 0.2777777778em 2.7777777778em;
}
.grid__col--1.theme__colors:last-of-type {
  margin-bottom: 2.7777777778em;
}
@media (min-width: 1px) and (max-width: 768px) {
  .grid__col--1.theme__colors {
    margin-bottom: 0.3333333333em;
  }
  .grid__col--1.theme__colors:last-child {
    margin-bottom: 2.2222222222em;
  }
}

.grid__col--2.theme__colors {
  display: flex;
  border-radius: 5px;
  border: none;
  font-size: 0.8888888889em;
  color: #737373;
  font-weight: 400;
  padding: 0.8333333333em 0.7222222222em 0.8333333333em;
  margin: 0 0.2777777778em 2.7777777778em;
}
.grid__col--2.theme__colors:last-of-type {
  margin-bottom: 2.7777777778em;
}
@media (min-width: 1px) and (max-width: 768px) {
  .grid__col--2.theme__colors {
    margin-bottom: 0.3333333333em;
  }
  .grid__col--2.theme__colors:last-child {
    margin-bottom: 2.2222222222em;
  }
}

.grid__col--3.theme__colors {
  display: flex;
  border-radius: 5px;
  border: none;
  font-size: 0.8888888889em;
  color: #737373;
  font-weight: 400;
  padding: 0.8333333333em 0.7222222222em 0.8333333333em;
  margin: 0 0.2777777778em 2.7777777778em;
}
.grid__col--3.theme__colors:last-of-type {
  margin-bottom: 2.7777777778em;
}
@media (min-width: 1px) and (max-width: 768px) {
  .grid__col--3.theme__colors {
    margin-bottom: 0.3333333333em;
  }
  .grid__col--3.theme__colors:last-child {
    margin-bottom: 2.2222222222em;
  }
}

.grid__col--4.theme__colors {
  display: flex;
  border-radius: 5px;
  border: none;
  font-size: 0.8888888889em;
  color: #737373;
  font-weight: 400;
  padding: 0.8333333333em 0.7222222222em 0.8333333333em;
  margin: 0 0.2777777778em 2.7777777778em;
}
.grid__col--4.theme__colors:last-of-type {
  margin-bottom: 2.7777777778em;
}
@media (min-width: 1px) and (max-width: 768px) {
  .grid__col--4.theme__colors {
    margin-bottom: 0.3333333333em;
  }
  .grid__col--4.theme__colors:last-child {
    margin-bottom: 2.2222222222em;
  }
}

.grid__col--5.theme__colors {
  display: flex;
  border-radius: 5px;
  border: none;
  font-size: 0.8888888889em;
  color: #737373;
  font-weight: 400;
  padding: 0.8333333333em 0.7222222222em 0.8333333333em;
  margin: 0 0.2777777778em 2.7777777778em;
}
.grid__col--5.theme__colors:last-of-type {
  margin-bottom: 2.7777777778em;
}
@media (min-width: 1px) and (max-width: 768px) {
  .grid__col--5.theme__colors {
    margin-bottom: 0.3333333333em;
  }
  .grid__col--5.theme__colors:last-child {
    margin-bottom: 2.2222222222em;
  }
}

.grid__col--6.theme__colors {
  display: flex;
  border-radius: 5px;
  border: none;
  font-size: 0.8888888889em;
  color: #737373;
  font-weight: 400;
  padding: 0.8333333333em 0.7222222222em 0.8333333333em;
  margin: 0 0.2777777778em 2.7777777778em;
}
.grid__col--6.theme__colors:last-of-type {
  margin-bottom: 2.7777777778em;
}
@media (min-width: 1px) and (max-width: 768px) {
  .grid__col--6.theme__colors {
    margin-bottom: 0.3333333333em;
  }
  .grid__col--6.theme__colors:last-child {
    margin-bottom: 2.2222222222em;
  }
}

.grid__col--7.theme__colors {
  display: flex;
  border-radius: 5px;
  border: none;
  font-size: 0.8888888889em;
  color: #737373;
  font-weight: 400;
  padding: 0.8333333333em 0.7222222222em 0.8333333333em;
  margin: 0 0.2777777778em 2.7777777778em;
}
.grid__col--7.theme__colors:last-of-type {
  margin-bottom: 2.7777777778em;
}
@media (min-width: 1px) and (max-width: 768px) {
  .grid__col--7.theme__colors {
    margin-bottom: 0.3333333333em;
  }
  .grid__col--7.theme__colors:last-child {
    margin-bottom: 2.2222222222em;
  }
}

.grid__col--8.theme__colors {
  display: flex;
  border-radius: 5px;
  border: none;
  font-size: 0.8888888889em;
  color: #737373;
  font-weight: 400;
  padding: 0.8333333333em 0.7222222222em 0.8333333333em;
  margin: 0 0.2777777778em 2.7777777778em;
}
.grid__col--8.theme__colors:last-of-type {
  margin-bottom: 2.7777777778em;
}
@media (min-width: 1px) and (max-width: 768px) {
  .grid__col--8.theme__colors {
    margin-bottom: 0.3333333333em;
  }
  .grid__col--8.theme__colors:last-child {
    margin-bottom: 2.2222222222em;
  }
}

.grid__col--9.theme__colors {
  display: flex;
  border-radius: 5px;
  border: none;
  font-size: 0.8888888889em;
  color: #737373;
  font-weight: 400;
  padding: 0.8333333333em 0.7222222222em 0.8333333333em;
  margin: 0 0.2777777778em 2.7777777778em;
}
.grid__col--9.theme__colors:last-of-type {
  margin-bottom: 2.7777777778em;
}
@media (min-width: 1px) and (max-width: 768px) {
  .grid__col--9.theme__colors {
    margin-bottom: 0.3333333333em;
  }
  .grid__col--9.theme__colors:last-child {
    margin-bottom: 2.2222222222em;
  }
}

.grid__col--10.theme__colors {
  display: flex;
  border-radius: 5px;
  border: none;
  font-size: 0.8888888889em;
  color: #737373;
  font-weight: 400;
  padding: 0.8333333333em 0.7222222222em 0.8333333333em;
  margin: 0 0.2777777778em 2.7777777778em;
}
.grid__col--10.theme__colors:last-of-type {
  margin-bottom: 2.7777777778em;
}
@media (min-width: 1px) and (max-width: 768px) {
  .grid__col--10.theme__colors {
    margin-bottom: 0.3333333333em;
  }
  .grid__col--10.theme__colors:last-child {
    margin-bottom: 2.2222222222em;
  }
}

.grid__col--11.theme__colors {
  display: flex;
  border-radius: 5px;
  border: none;
  font-size: 0.8888888889em;
  color: #737373;
  font-weight: 400;
  padding: 0.8333333333em 0.7222222222em 0.8333333333em;
  margin: 0 0.2777777778em 2.7777777778em;
}
.grid__col--11.theme__colors:last-of-type {
  margin-bottom: 2.7777777778em;
}
@media (min-width: 1px) and (max-width: 768px) {
  .grid__col--11.theme__colors {
    margin-bottom: 0.3333333333em;
  }
  .grid__col--11.theme__colors:last-child {
    margin-bottom: 2.2222222222em;
  }
}

.grid__col--12.theme__colors {
  display: flex;
  border-radius: 5px;
  border: none;
  font-size: 0.8888888889em;
  color: #737373;
  font-weight: 400;
  padding: 0.8333333333em 0.7222222222em 0.8333333333em;
  margin: 0 0.2777777778em 2.7777777778em;
}
.grid__col--12.theme__colors:last-of-type {
  margin-bottom: 2.7777777778em;
}
@media (min-width: 1px) and (max-width: 768px) {
  .grid__col--12.theme__colors {
    margin-bottom: 0.3333333333em;
  }
  .grid__col--12.theme__colors:last-child {
    margin-bottom: 2.2222222222em;
  }
}

.grid__col--1.theme__colors {
  background-color: #63CC82;
}
.grid__col--2.theme__colors {
  background-color: #51ddfc;
}
.grid__col--3.theme__colors {
  background-color: #DEB2EE;
}
.grid__col--4.theme__colors {
  background-color: #7EE6FD;
}
.grid__col--5.theme__colors {
  background-color: #88D9A0;
}
.grid__col--6.theme__colors {
  background-color: #3FABCA;
}
.grid__col--7.theme__colors {
  background-color: #EC9FA3;
}
.grid__col--8.theme__colors {
  background-color: #FD9F85;
}
.grid__col--9.theme__colors {
  background-color: #FD7856;
}
.grid__col--10.theme__colors {
  background-color: #E4757A;
}
.grid__col--11.theme__colors {
  background-color: #927BC1;
}
.grid__col--12.theme__colors {
  background-color: #80E8D1;
}

.btn--default {
  margin-top: 2.2222222222em;
}
.btn--success.theme__colors {
  background: #63CC82;
}
.btn--error.theme__colors {
  background: #E4757A;
}
.btn--warning.theme__colors {
  background: #FD7856;
}
.btn--info.theme__colors {
  background: #927BC1;
}
.btn--default.theme__colors {
  background: #51ddfc;
}

.link {
  color: #51ddfc;
  font-weight: 400;
}

.blockquote {
  width: 80%;
  margin: 0 auto;
  display: block;
  font-size: 1.3888888889em;
  line-height: 1.3888888889em;
  font-style: italic;
  border-left: 9px solid #58e1c1;
  border-top-left-radius: 5px;
  border-bottom-left-radius: 5px;
  padding: 0 0 0 0.7777777778em;
  margin: 20px 0 80px 20px;
  width: 85%;
}

/*# sourceMappingURL=styles.cs.map */
