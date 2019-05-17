<template>
  <div id="app">
  <h1>{{ $t('hello') }}</h1><br />
  <form>
    <select id="language-select" @change="setlanguage" required>
      <option value="" disabled selected hidden> language </option>
      <option value="en">English</option>
      <option value="ar">Arabic</option>
      <option value="ja">Japanese</option>
      <option value="zh">Chinese</option>
      <option value="fr">French</option>
      <option value="es">Spanish</option>
    </select>
  </form>
  </div>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'

export default {
  name: 'app',
  components: {
    HelloWorld
  },
  methods: {
    setlanguage(event) {
      let languageCode = event.target.value;
      console.log(languageCode)
      window.i18n.locale = languageCode;
    }
  }
}
</script>

<style>
@import url('https://fonts.googleapis.com/css?family=Noto+Sans&display=swap');
body {
  /* background-image: url('./assets/i18n.svg'); */
  background-repeat: repeat;
  background-size: 736px 380px;
}
#language-select {
  font-size: 1.6em;
  font-family: 'Noto Sans', sans-serif;
  border-width: 0 0 2px 0;
  margin-left: 16px;
  padding: 6px;
  cursor: pointer;
}
#app {
  font-family: 'Noto Sans', sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  display: flex;
  align-items: center;
  justify-content: center;
  height: 90vh;
}
/* select:invalid { color: gray; } */
select:required:invalid  { color: gray; }
option[value=""][disabled] {
  display: none;
}
option {
  color: #2c3e50;
  cursor: pointer;
}
</style>
