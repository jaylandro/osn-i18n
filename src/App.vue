<template>
  <div id="app" dir="auto">
    <div class="reveal">
      <div class="slides" dir="auto">
        <section class="i18n-bg">
          <h1> Welcome </h1>
        </section>
        <section>
          <h1>Goals...</h1>
          <ul class="goals">
            <li>Translations 🎉</li>
            <li>Country Data 🌍</li>
            <li>Numeric Formatting 🔢</li>
            <li>Automation throughout! 🤖</li>
          </ul>
        </section>
        <section dir="auto">
          <h1>{{ $t('hello') }}</h1><br />
          <select id="language-select" @change="setlanguage" required>
            <option value="" disabled selected hidden> language </option>
            <option value="en">english</option>
            <option value="ar">arabic</option>
            <option value="ja">japanese</option>
            <option value="zh">chinese</option>
            <option value="fr">french</option>
            <option value="es">spanish</option>
          </select>
        </section>  
        <section>
          <h2>
            <a href="https://kazupon.github.io/vue-i18n/guide/formatting.html#named-formatting" target="_blank">
              Vue-i18n
            </a>
          </h2>  
          <pre>
            <code>
            this.$i18n.locale = languageCode; 
            </code>
          </pre>
        </section>
      </div>
    </div>
  </div>
</template>

<script>
import Reveal from 'reveal.js/js/reveal'

export default {
  name: 'app',
  components: {
    // HelloWorld
  },
  methods: {
    setlanguage(event) {
      let languageCode = event.target.value;
      this.$i18n.locale = languageCode;
    }
  },
  mounted() {
    Reveal.initialize()
  }
}
</script>

<style>
@import url('https://fonts.googleapis.com/css?family=Noto+Sans&display=swap');
@import url('../node_modules/reveal.js/css/reveal.css');
@import url('../node_modules/reveal.js/css/theme/white.css');
.i18n-bg {
  background-image: url('./assets/i18n.svg');
  background-repeat: repeat;
  background-size: 736px 380px;
}
.i18n-bg h1 {
  display: block;
  background: white;
  height: 70px;
}
input, select {
  background: white;
  font-size: 0.5em;
  font-family: 'Noto Sans', sans-serif;
  border-width: 0 0 2px 0;
  padding: 6px;
  cursor: pointer;
}
#app {
  font-family: 'Noto Sans', sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  text-align: center;
  height: 100vh;
}
select:invalid { color: gray; }
select:required:invalid  { color: gray; }
option[value=""][disabled] {
  display: none;
}
option {
  color: #2c3e50;
  cursor: pointer;
}
.goals {
  line-height: 1.8em;
}
</style>
