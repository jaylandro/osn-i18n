<template>
  <div @click.stop>
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
  </div>
</template>

<script>
export default {
  name: 'HelloWorld',
  methods: {
    setlanguage(event) {
      event.stopPropagation()
      let languageCode = event.target.value;
      this.$i18n.locale = languageCode;
    }
  },
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h1 {
  height: 150px;
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
</style>
